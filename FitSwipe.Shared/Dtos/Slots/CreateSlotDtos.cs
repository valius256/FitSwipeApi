using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class CreateSlotDtos
    {
        [Required]
        public required DateTime StartTime { get; set; }
        [Required]
        public required DateTime EndTime { get; set; }
        //public Guid? TrainingId { get; set; }
        //public SlotType Type { get; set; } //Phân biệt slot này là slot rảnh hay slot đã đặt
    }
}
