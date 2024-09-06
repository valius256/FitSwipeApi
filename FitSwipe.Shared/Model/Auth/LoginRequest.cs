using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Model.Auth
{
    public class LoginRequest
    {
        [Required] public string? Email { get; set; }
        [Required] public string? Password { get; set; }
    }
}