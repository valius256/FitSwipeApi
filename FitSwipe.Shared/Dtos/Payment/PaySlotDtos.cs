namespace FitSwipe.Shared.Dtos.Payment
{
    public class PaySlotDtos
    {
        public string? OrderDescription { get; set; } = string.Empty;
        public required List<string> SlotIds { get; set; } = new List<string>();
        public string? ReturnUrl { get; set; }

        public List<Guid> GetSlotGuids()
        {
            return SlotIds.Select(id => Guid.Parse(id)).ToList();
        }
    }


}
