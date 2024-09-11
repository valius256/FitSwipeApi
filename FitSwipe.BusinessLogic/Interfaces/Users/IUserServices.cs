using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.Users;

namespace FitSwipe.BusinessLogic.Interfaces.Users
{
    public interface IUserServices
    {
        Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos);
        Task<User> GetUserByIdRequired(string id);
    }
}
