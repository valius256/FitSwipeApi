using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.BusinessLogic.Interfaces.Slots
{
    public interface ISlotVideoServices
    {
        public Task<CreateSlotVideoDtos> AddSlotVideoAsync(SlotVideoDto slotVideos);
    }
}
