using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.User;

namespace FitSwipe.BusinessLogic.Interfaces.User
{
    public interface IUserServices
    {
        Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos);

    }
}
