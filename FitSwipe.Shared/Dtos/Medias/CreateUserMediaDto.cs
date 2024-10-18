﻿
using FitSwipe.Shared.Enum;

namespace FitSwipe.Shared.Dtos.Medias
{
    public class CreateUserMediaDto
    {
        public string MediaUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsVideo { get; set; } = false;
    }
}
