using FitSwipe.Shared.Model.Auth;

namespace FitSwipe.BusinessLogic.Interfaces.Auth
{
    public interface IFirebaseAuthServices
    {
        Task<string> RegisterUser(RegisterRequestModel registerRequest);
        Task<string> ForgotPassword(string email);
        //Task<UserRecord?> GetUserAsync(string? uid, string? email, string? phone);
        Task<bool> DeleteUserAsync(string? email);
        Task SetCustomClaimsAsync(string userId, Dictionary<string, object> claims);
        //Task<list<Exporteduserrecord>> Getalluserrecord();
        //Task<string> CreateSessionCookieAsync(string idToken, SessionCookieOptions options);
    }
}
