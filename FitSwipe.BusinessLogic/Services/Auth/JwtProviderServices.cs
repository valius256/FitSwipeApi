using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Users;
using System.Text.Json.Serialization;

namespace FitSwipe.BusinessLogic.Services.Auth
{
    public class JwtProviderServices : IJwtProviderServices
    {
        private readonly IFirebaseAuthServices _fireBaseAuthServices;
        private readonly HttpClient _httpClient;

        private readonly IUserRepository _userRepository;

        public JwtProviderServices(HttpClient httpClient, IUserRepository userRepository,
             IFirebaseAuthServices fireBaseAuthServices)
        {
            _httpClient = httpClient;
            _userRepository = userRepository;
            _fireBaseAuthServices = fireBaseAuthServices;
        }

        public Task<AuthenResponseDto> GetForCredentialsAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        //        public async Task<AuthenResponseDto> GetForCredentialsAsync(string email, string password)
        //        {
        //            var responseModel = new AuthenResponseDto();

        //            try
        //            {
        //                var request = new
        //                {
        //                    email,
        //                    password,
        //                    returnSecureToken = true
        //                };

        //        var response = await _httpClient.PostAsJsonAsync("", request);
        //                if (!response.IsSuccessStatusCode)
        //                {
        //                    var errorContent = await response.Content.ReadAsStringAsync();

        //                    try
        //                    {
        //                        // Parse the error content as JSON
        //                        var parsedJson = Newtonsoft.Json.Linq.JObject.Parse(errorContent);
        //        responseModel.Code = parsedJson["error"]?["code"]?.ToString() ?? throw new InvalidOperationException();
        //        responseModel.Message = parsedJson["error"]?["message"]?.ToString() ?? throw new InvalidOperationException();
        //    }
        //                    catch (Exception)
        //                    {
        //                        // If parsing fails, set code to the status code and use raw content as message
        //                        responseModel.Code = response.StatusCode.ToString();
        //                        responseModel.Message = errorContent;
        //                    }

        //return responseModel;
        //                }

        //                var authToken = await response.Content.ReadFromJsonAsync<AuthToken>();
        //if (authToken == null)
        //    throw new InvalidOperationException("Authentication token is null");

        //var userIdConverter = authToken.LocalId;
        //var userInDb = await _userRepository.GetByIdAsync(userIdConverter.ToGuid());

        //var customClaims = new Dictionary<string, object>
        //                {
        //                    { "roles", userInDb.Role.ToString() },

        //                };
        //await _fireBaseAuthServices.SetCustomClaimsAsync(authToken.LocalId, customClaims);

        //// Reauthenticate the user to get a new token with the custom claims
        //var reAuthRequest = new
        //{
        //    email,
        //    password,
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

        //var options = new SessionCookieOptions
        //{
        //    ExpiresIn = TimeSpan.FromDays(7),
        //};

        //var cookieExtendSession = await _fireBaseAuthServices.CreateSessionCookieAsync(reAuthToken.IdToken, options);
        //responseModel.Code = response.StatusCode.ToString();
        //responseModel.Message = cookieExtendSession;
        //            }
        //            catch (Exception exception)
        //            {
        //                responseModel.Code = "Error";
        //responseModel.Message = exception.Message;
        //            }

        //            return responseModel;
        //        }



        public class AuthToken
        {
            [JsonPropertyName("kind")] public string Kind { get; set; }

            [JsonPropertyName("localId")] public string LocalId { get; set; }

            [JsonPropertyName("Email")] public string Email { get; set; }

            [JsonPropertyName("displayName")] public string DisplayName { get; set; }

            [JsonPropertyName("idToken")] public string IdToken { get; set; }

            [JsonPropertyName("registered")] public bool Registered { get; set; }

            [JsonPropertyName("refreshToken")] public string RefreshToken { get; set; }

            [JsonPropertyName("expiresIn")] public long ExpiresIn { get; set; }

            [JsonPropertyName("role")] public string Role { get; set; }
        }
    }
}
