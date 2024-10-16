
using FitSwipe.Shared.Dtos.Medias;

namespace FitSwipe.BusinessLogic.Interfaces.Users
{
    public interface IUserMediaService
    {
        Task<GetUserMediaDto> GetUserMediaRequiredById(Guid userMediaId);
        Task<GetUserMediaDto> CreateUserMediaAsync(CreateUserMediaDto userMediaDto, string userId);
        Task<GetUserMediaDto> UpdateUserMediaAsync(UpdateUserMediaDto userMediaDto, string userId);
        Task DeleteUserMediaAsync(Guid userMediaId, string userId);
    }
}
