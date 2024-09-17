using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Models.User;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Model.Auth;

namespace FitSwipe.BusinessLogic.Interfaces.Auth
{
    public interface IFirebaseAuthServices
    {
        Task<bool> GenerateVerificationEmailAsync(string email);
        Task<RegisterAuthModel> RegisterUserWithFirebaseAsync(RegisterRequestModel registerRequest);
        Task<string?> ForgotPasswordAsync(string email);
        //Task<UserRecord?> GetUserAsync(string? uid, string? email, string? phone);
        Task<bool> DeleteUserAsync(string? email);
        Task VerifyFirebaseToken(string token);
        Task<AuthenResponseDto> LoginWithFireBase(LoginRequest body);
        Task SetCustomClaimsAsync(string userId, Dictionary<string, object> claims);
        //Task<list<Exporteduserrecord>> Getalluserrecord();
        Task<string> CreateSessionCookieAsync(string idToken, SessionCookieOptions options);
    }
}
