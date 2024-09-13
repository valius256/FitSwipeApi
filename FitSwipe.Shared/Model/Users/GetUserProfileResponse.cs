﻿using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Model.Users
{
    public class GetUserProfileResponse
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public Role Role { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
