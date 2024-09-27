using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class CreateSlotDtos
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid? TrainingId { get; set; }
        public SlotType Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
    }
}
