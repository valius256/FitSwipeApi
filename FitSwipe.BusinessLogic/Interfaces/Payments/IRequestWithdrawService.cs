

using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.Shared.Dtos.RequestWithdraw;

namespace FitSwipe.BusinessLogic.Interfaces.Payments
{
    public interface IRequestWithdrawService
    {
        Task<PagedResult<GetRequestWithdrawDto>> GetAllRequestWithdraw(int limit, int page, bool? isUpdated);
        Task<PagedResult<GetRequestWithdrawDto>> GetRequestWithdrawOfUser(string userId, int limit, int page);
        Task<GetRequestWithdrawDto> GetRequestWithdrawRequiredById(Guid id);
        Task<GetRequestWithdrawDto> CreateRequestWithdraw(CreateRequestWithdrawDto createRequestWithdrawDto, string userId);
        Task<GetRequestWithdrawDto> UpdateRequestWithdraw(UpdateRequestWithdrawDto updateRequestWithdrawDto, string userId);
        Task DeleteRequestWithdraw(Guid id, string userId);
    }
}
