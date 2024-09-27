using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Dtos.Auth
{
    public class LoginRequestDtos
    {
        [Required] public string? Email { get; set; }
        [Required] public string? Password { get; set; }
    }
}