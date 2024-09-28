using FitSwipe.Shared.Dtos.Slots;

namespace FitSwipe.BusinessLogic.Interfaces.Slot
{
    public interface ISlotVideoServices
    {
        public Task<CreateSlotVideoDtos> AddSlotVideoAsync(SlotVideoDto slotVideos);
    }
}
