﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FitSwipe.Shared.Dtos.Slots
{
    public class CreateSlotVideoDtos
    {
        [Required]
        public Guid SlotId { get; set; }
        [Required]
        public string VideoUrl { get; set; } = string.Empty;
        [AllowNull]
        public string ThumbnailUrl { get; set; }
        [AllowNull]
        public string Description { get; set; }
    }
}
