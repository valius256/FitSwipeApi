using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.BusinessLogic.Interfaces.Slots
{
    public interface ISlotVideoServices
    {
        Task<GetSlotVideoDto> AddSlotVideoAsync(CreateSlotVideoDtos slotVideos);
        Task<List<GetSlotVideoDto>> AddRangeSlotVideoAsync(List<CreateSlotVideoDtos> slotVideos);
        Task DeleteSlotVideoAsync(Guid id);
        Task DeleteRangeSlotVideoAsync(List<Guid> ids);
        Task UpdateRangeSlotVideoAsync(List<SlotVideos> slotVideos);
    }
}
