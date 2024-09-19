namespace FitSwipe.Shared.Dtos.Users
{
    public class QueryMatchedPTDto // Remove later
    {
        public required string UserId { get; set; }
        public int Limit { get; set; } = 10;
        public int Page { get; set; } = 1;
    }
}
