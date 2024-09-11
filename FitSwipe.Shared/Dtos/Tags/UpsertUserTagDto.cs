namespace FitSwipe.Shared.Dtos.Tags
{
    public class UpsertUserTagDto
    {
        public string UserId { get; set; } = string.Empty;// Remove later

        public List<Guid> NewTagIds { get; set; } = new List<Guid>();
    }
}
