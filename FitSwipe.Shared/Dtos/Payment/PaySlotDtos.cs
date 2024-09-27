namespace FitSwipe.Shared.Dtos.Payment
{
    public class PaySlotDtos
    {
        public string? OrderDescription { get; set; } = string.Empty;
        public required List<Guid> SlotIds { get; set; } = new List<Guid>();
        public string? ReturnUrl { get; set; }
    }
}
