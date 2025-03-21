﻿using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Users
{
    public class GetSimpleUserDto
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public string? AvatarUrl { get; set; }
        public Role Role { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
