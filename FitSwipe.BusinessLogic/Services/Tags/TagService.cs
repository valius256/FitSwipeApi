

using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Exceptions;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Tags
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<GetTagDto>> GetAllTags()
        {
            return (await _tagRepository.GetAllAsync()).Adapt<List<GetTagDto>>();
        }
        public async Task<List<GetTagDto>> GetTagsQueried(QueryTagDto queryTagDto)
        {
            return (await _tagRepository.GetPagedTags(queryTagDto)).Adapt<List<GetTagDto>>();
        }

        public async Task<GetTagDto?> GetTagById(Guid id)
        {
            return (await _tagRepository.FindOneAsync(t => t.Id == id)).Adapt<GetTagDto?>();
        }

        public async Task<Tag> GetTagByIdRequired(Guid id)
        {
            var tag = (await _tagRepository.FindOneAsync(t => t.Id == id));
            if (tag == null)
            {
                throw new DataNotFoundException("Tag not found");
            }
            return tag;
        }

        public async Task<GetTagDto> CreateTag(CreateTagDto createTagDto)
        {
            var tag = createTagDto.Adapt<Tag>();
            var createdTag = await _tagRepository.AddAsync(tag);
            return createdTag.Adapt<GetTagDto>();
        }

        public async Task UpdateTag(UpdateTagDto updateTagDto)
        {
            var exisitedTag = await _tagRepository.FindOneAsync(t => t.Id == updateTagDto.Id);
            if (exisitedTag == null)
            {
                throw new DataNotFoundException("Tag not found");
            }
            exisitedTag.Adapt(updateTagDto);
            await _tagRepository.UpdateAsync(exisitedTag);
        }

        public async Task DeleteTag(Guid tagId)
        {
            var exisitedTag = await _tagRepository.FindOneAsync(t => t.Id == tagId);
            if (exisitedTag == null)
            {
                throw new DataNotFoundException("Tag not found");
            }
            await _tagRepository.DeleteAsync(tagId);
        }
    }
}
