
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class UpdateSlotVideoDto
    {
        public required Guid Id { get; set; }
        public string? Description { get; set; }
    }
}
