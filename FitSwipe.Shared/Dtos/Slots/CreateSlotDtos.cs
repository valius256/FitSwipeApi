namespace FitSwipe.Shared.Dtos.Slots
{
    public class CreateSlotDtos
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid? TrainingId { get; set; }
        //public SlotType Type { get; set; } = SlotType.Free;
        //public SlotStatus Status { get; set; } = SlotStatus.Unbooked;
        //public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.NotPaid;
        public Guid? SlotVideoId { get; set; }
    }
}
