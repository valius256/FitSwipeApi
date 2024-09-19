
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.Shared.Dtos.Tags;

namespace FitSwipe.BusinessLogic.Interfaces.Tags
{
    public interface ITagService
    {
        Task<List<GetTagDto>> GetAllTags();
        Task<List<GetTagDto>> GetTagsQueried(QueryTagDto queryTagDto);
        Task<GetTagDto?> GetTagById(Guid id);
        Task<Tag> GetTagByIdRequired(Guid id);
        Task<GetTagDto> CreateTag(CreateTagDto createTagDto);
        Task UpdateTag(UpdateTagDto updateTagDto);
        Task DeleteTag(Guid tagId);
    }
}
