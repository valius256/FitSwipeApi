using FitSwipe.Shared.Dtos.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Auth
{
    public interface IJwtProviderServices
    {
        Task<AuthenResponseDto> GetForCredentialsAsync(string email, string password);
    }
}
