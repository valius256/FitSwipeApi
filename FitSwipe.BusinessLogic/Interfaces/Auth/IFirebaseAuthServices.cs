using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Models.Users;
using FitSwipe.Shared.Dtos.Auth;
using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Auth
{
    public interface IFirebaseAuthServices
    {
        Task<GetUserProfileDtos> RegisterUser(RegisterRequestDtos registerDtos);
        Task<bool> GenerateVerificationEmailAsync(string email);
        Task<RegisterAuthModel> RegisterUserWithFirebaseAsync(RegisterRequestDtos registerRequest);
        Task<string?> GenerateFirebaseForgotPasswordLinkAsync(string email);
        //Task<UserRecord?> GetUserAsync(string? uid, string? email, string? phone);
        Task<bool> DeleteUserAsync(string? email);
        Task<string> ForgotPasswordAsync(string email);
        Task VerifyFirebaseToken(string token);
        Task<AuthenResponseDto> LoginWithFireBase(LoginRequestDtos body);
        Task SetCustomClaimsAsync(string userId, Dictionary<string, object> claims);
        //Task<list<Exporteduserrecord>> Getalluserrecord();
        Task<string> CreateSessionCookieAsync(string idToken, SessionCookieOptions options);
    }
}
