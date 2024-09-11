
using FitSwipe.Shared.Dtos.Tags;

namespace FitSwipe.BusinessLogic.Interfaces.Tags
{
    public interface ITagService 
    {
        Task<List<GetTagDto>> GetAllTags();
        Task<GetTagDto?> GetTagById(Guid id);
        Task<GetTagDto> GetTagByIdRequired(Guid id);
        Task<GetTagDto> CreateTag(CreateTagDto createTagDto);
        Task UpdateTag(UpdateTagDto updateTagDto);
        Task DeleteTag(Guid tagId);
    }
}
