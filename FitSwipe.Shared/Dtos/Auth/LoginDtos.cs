namespace FitSwipe.Shared.Dtos.Auth
{
    public class LoginDtos
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}
