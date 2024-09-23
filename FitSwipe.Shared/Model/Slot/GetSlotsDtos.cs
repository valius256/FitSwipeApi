using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Model.Slot
{
    public class GetSlotsDtos
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public Guid CreateById { get; set; }
        public DateTime EndTime { get; set; }
        public string? TeachAddress { get; set; }
        public bool IsOnline { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public SlotStatus SlotStatus { get; set; }

    }
}