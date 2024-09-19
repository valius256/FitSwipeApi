﻿using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Models.User;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;
using Mapster;
using System.Net.Http.Json;
using static FitSwipe.BusinessLogic.Services.Auth.JwtProviderServices;


namespace FitSwipe.BusinessLogic.Services.Auth
{
    public class FirebaseAuthServices : IFirebaseAuthServices
    {
        private readonly IEmailServices _emailServices;
        private readonly HttpClient _httpClient;
        private readonly IUserRepository _userRepository;


        public FirebaseAuthServices(IEmailServices emailServices, HttpClient httpClient, IUserRepository userRepository)
        {
            _emailServices = emailServices;
            _httpClient = httpClient;
            _userRepository = userRepository;


        }

        public async Task<bool> GenerateVerificationEmailAsync(string email)
        {


            var link = await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(email);

            var toAddress = new List<string> { email };
            var emailParams = new Dictionary<string, string>()
            {
                { "UserName", $"{email}" },
                {"VerificationLink", $"{link}"}
            };

            await _emailServices.SendAsync(EmailType.Register_Mail, toAddress, new List<string>(), emailParams,
                false);
            return true;
        }


        public async Task<RegisterAuthModel> RegisterUserWithFirebaseAsync(RegisterRequestModel registerRequestModel)
        {
            var userForFireBaseAuth = new UserRecordArgs
            {
                Email = registerRequestModel.Email,
                Password = registerRequestModel.Password,
                DisplayName = registerRequestModel.Email,
            };

            var userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(userForFireBaseAuth);
            var link = await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(userRecord.Email);

            return new RegisterAuthModel()
            {
                RegisterLink = link,
                UserFirebaseId = userRecord.Uid
            };
        }

        public async Task<string?> ForgotPasswordAsync(string email)
        {
            if (await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email) == null)
            {
                return null;
            }

            return await FirebaseAuth.DefaultInstance.GeneratePasswordResetLinkAsync(email);
        }

        public async Task VerifyFirebaseToken(string token)
        {
            var firebaseToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
        }

        public async Task SetCustomClaimsAsync(string userId, Dictionary<string, object> claims)
        {
            await FirebaseAuth.DefaultInstance.SetCustomUserClaimsAsync(userId, claims);
        }

        public async Task<bool> DeleteUserAsync(string? email)
        {
            var user = await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email);
            if (user == null)
                throw new ModelException("User not found", "not found", "");

            await FirebaseAuth.DefaultInstance.DeleteUserAsync(user.Uid);
            return true;
        }

        public async Task<string> CreateSessionCookieAsync(string idToken, SessionCookieOptions options)
        {
            var sessionCookie = await FirebaseAuth.DefaultInstance
                .CreateSessionCookieAsync(idToken, options);
            return sessionCookie;
        }

        public async Task<AuthenResponseDto> LoginWithFireBase(LoginRequest loginDto)
        {
            if (string.IsNullOrEmpty(loginDto.Email))
            {
                throw new ArgumentNullException(nameof(loginDto.Email), "Email cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(loginDto.Password))
            {
                throw new ArgumentNullException(nameof(loginDto.Password), "Password cannot be null or empty.");
            }

            var responseModel = new AuthenResponseDto();

            try
            {
                var request = new
                {
                    loginDto.Email,
                    loginDto.Password,
                    returnSecureToken = true
                };

                var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyCO7BUe_jNgpY-EL8LM_XW0pzlkfvyFSns";

                var response = await _httpClient.PostAsJsonAsync(url, request);
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var parsedJson = Newtonsoft.Json.Linq.JObject.Parse(errorContent);
                    responseModel.Code = parsedJson["error"]?["code"]?.ToString() ?? response.StatusCode.ToString();
                    responseModel.Message = parsedJson["error"]?["message"]?.ToString() ?? errorContent;
                    return responseModel;
                }

                var authToken = await response.Content.ReadFromJsonAsync<AuthToken>();
                if (authToken == null)
                    throw new InvalidOperationException("Authentication token is null");

               
                var userInDb = await _userRepository.FindOneAsync(user => user.FireBaseId == authToken.LocalId);
                //==== This section will be removed later ====
                if (userInDb == null)
                {
                    var recordToFetch = await FirebaseAuth.DefaultInstance.GetUserAsync(authToken.LocalId);
                    if (recordToFetch == null)
                    {
                        throw new DataNotFoundException("User not found");
                    }
                    else
                    {
                        userInDb = recordToFetch.Adapt<User>();
                        userInDb.Id = Guid.NewGuid();
                        userInDb.Password = "defaultPassword";
                        userInDb.Phone = recordToFetch.PhoneNumber != null ? recordToFetch.PhoneNumber : "0935333333";
                        userInDb.FireBaseId = recordToFetch.Uid;
                        userInDb.Role = Role.Trainee; //default;
                        userInDb.UserName =
                            recordToFetch.DisplayName != null ? recordToFetch.DisplayName : recordToFetch.Email;
                    }
                }
                //==============================================

                var customClaims = new Dictionary<string, object>
                {
                    { "roles", userInDb.Role.ToString() },
                    { "User", userInDb },


                };
                await SetCustomClaimsAsync(authToken.LocalId, customClaims);

                //var reAuthRequest = new
                //{
                //    loginDto.Email,
                //    loginDto.Password,
                //    returnSecureToken = true
                //};

                //var reAuthResponse = await _httpClient.PostAsJsonAsync("", reAuthRequest);
                //if (!reAuthResponse.IsSuccessStatusCode)
                //{
                //    responseModel.Code = reAuthResponse.StatusCode.ToString();
                //    responseModel.Message = await reAuthResponse.Content.ReadAsStringAsync();
                //    return responseModel;
                //}

                //var reAuthToken = await reAuthResponse.Content.ReadFromJsonAsync<AuthToken>();
                //if (reAuthToken == null)
                //    throw new InvalidOperationException("Re-authentication token is null");

                var options = new SessionCookieOptions
                {
                    ExpiresIn = TimeSpan.FromDays(7),
                };

                var cookieExtendSession = await CreateSessionCookieAsync(authToken.IdToken, options);
                responseModel.Code = response.StatusCode.ToString();
                responseModel.Message = cookieExtendSession;
            }
            catch (Exception exception)
            {
                responseModel.Code = "Error";
                responseModel.Message = exception.Message;
            }

            return responseModel;
        }


    }
}
