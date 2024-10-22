
namespace FitSwipe.Shared.Dtos.Users
{
    public class GetUserWithMatchScoreDto
    {
        public GetUserWithTagDto User { get; set; } = default!;
        public double MatchScore { get; set; }

    }
}
