using Firebase.Auth;
using Firebase.Auth.Providers;
using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.BusinessLogic.Models.Users;
using FitSwipe.DataAccess.Model;
using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.Shared.Dtos.Auth;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using Mapster;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Json;
using static FitSwipe.BusinessLogic.Services.Auths.JwtProviderServices;


namespace FitSwipe.BusinessLogic.Services.Auths
{
    public class FirebaseAuthServices : IFirebaseAuthServices
    {
        private readonly IEmailServices _emailServices;
        private readonly HttpClient _httpClient;
        private readonly IUserServices _userServices;
        private readonly FirebaseUpload _firebaseUpload;
        private readonly FirebaseAuthClient _firebaseAuthClient;
        public FirebaseAuthServices(IEmailServices emailServices, HttpClient httpClient, IUserServices userServices, IOptions<FirebaseUpload> firebaseUpload)
        {
            _emailServices = emailServices;
            _httpClient = httpClient;
            _userServices = userServices;
            _firebaseUpload = firebaseUpload.Value;
            var config = new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyCO7BUe_jNgpY-EL8LM_XW0pzlkfvyFSns",
                AuthDomain = "fitswipe-1c7b4.firebaseapp.com",

            };
            _firebaseAuthClient = new FirebaseAuthClient(config);
        }

        public async Task<string> ForgotPasswordAsync(string email)
        {

            var resetPasswordLink = await GenerateFirebaseForgotPasswordLinkAsync(email);
            if (resetPasswordLink == null)
            {
                return "Email của bạn không nằm trong hệ thống. Vui lòng đăng ký";
            }

            var emailParams = new Dictionary<string, string>()
            {
                { "Name", $"{email}" },
                {"ResetPasswordLink", $"{resetPasswordLink}"}
            };
            var toAddress = new List<string>() { email };
            await _emailServices.SendAsync(EmailType.Forgot_Password, toAddress, new List<string>(), emailParams,
                false);

            return "Kiểm tra hộp thư của bạn đi. FitSwipe 😂";
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


        public async Task<RegisterAuthModel> RegisterUserWithFirebaseAsync(RegisterRequestDtos registerRequestModel)
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

        public async Task<string?> GenerateFirebaseForgotPasswordLinkAsync(string email)
        {
            if (await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email) == null)
            {
                return null;
            }

            var rs = await FirebaseAuth.DefaultInstance.GeneratePasswordResetLinkAsync(email);
            return rs;
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

        public async Task<GetUserProfileDtos> RegisterUser(RegisterRequestDtos registerDtos)
        {
            var registerAuthModel = await RegisterUserWithFirebaseAsync(registerDtos);

            // Map Register DTO to User entity
            var userEntity = registerDtos.Adapt<DataAccess.Model.Entity.User>();

            // Populate additional fields for the User entity
            userEntity.FireBaseId = registerAuthModel.UserFirebaseId;
            userEntity.Role = registerDtos.Role;
            userEntity.Email = registerDtos.Email;
            userEntity.UserName = registerDtos.Name;
            userEntity.Status = UserStatus.Active;

            // Add the User entity to the database
            await _userServices.AddUserAsync(userEntity);


            var toAddress = new List<string> { registerDtos.Email };
            var emailParams = new Dictionary<string, string>()
            {
                { "Name", $"{registerDtos.Email}" },
                {"VerificationLink", $"{registerAuthModel.RegisterLink}"}
            };

            await _emailServices.SendAsync(EmailType.Register_Mail, toAddress, new List<string>(), emailParams,
                false);


            var userResponseModel = new GetUserProfileDtos()
            {
                Email = registerDtos.Email,
                Password = registerDtos.Password,
                Role = registerDtos.Role,
                CreateDate = userEntity.CreatedDate
            };

            return userResponseModel;
        }

        public async Task<AuthenResponseDto> LoginWithFireBase(LoginRequestDtos loginDto)
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

                var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={_firebaseUpload.SignInPasswordKey}";

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


                var userInDb = await _userServices.GetUserByIdRequiredAsync(authToken.LocalId);

                var customClaims = new Dictionary<string, object>
                {
                    { "roles", userInDb.Role.ToString() },
                    { "userEntityId", userInDb.Id.ToString() }

                };
                await SetCustomClaimsAsync(authToken.LocalId, customClaims);

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

        public async Task<FacebookUser> VerifyFacebookAccessToken(string accessToken)
        {
            var httpClient = new HttpClient();
            var facebookUrl = $"https://graph.facebook.com/me?access_token={accessToken}&fields=id,name,email";
            var response = await httpClient.GetStringAsync(facebookUrl);
            var userInfo = JsonConvert.DeserializeObject<FacebookUser>(response);
            return userInfo;
        }



        public async Task<UserCredential> SignInWithFacebookToken(string facebookAccessToken)
        {
            var credential = FacebookProvider.GetCredential(facebookAccessToken);
            var authLink = await _firebaseAuthClient.SignInWithCredentialAsync(credential);
            if (authLink == null)
            {
                throw new ModelException("Error", "authLink is null", "Error");
            }
            else
            {
                var fireBaseUserId = authLink.User.Uid;
                var userExistInDb = await _userServices.GetUserByIdRequiredAsync(fireBaseUserId);
                if (userExistInDb == null)
                {
                    var userRecord = await FirebaseAuth.DefaultInstance.GetUserAsync(fireBaseUserId);
                    var user = new DataAccess.Model.Entity.User()
                    {
                        FireBaseId = fireBaseUserId,
                        Email = userRecord.Email,
                        UserName = userRecord.DisplayName,
                        Role = Role.Trainee,
                        Status = UserStatus.Active
                    };
                    await _userServices.AddUserAsync(user);
                }
            }

            return authLink;
        }
    }
}
