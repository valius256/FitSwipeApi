namespace FitSwipe.Shared.Model.Auth
{
    public class LoginReponse
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}
