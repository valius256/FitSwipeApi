namespace FitSwipe.Shared.Model.Payment
{
    public class PaySlotDtos
    {
        public string? OrderDescription { get; set; } = string.Empty;
        public Guid SlotId { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
