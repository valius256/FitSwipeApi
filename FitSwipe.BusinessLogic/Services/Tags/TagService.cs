

using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.DataAccess.Model.Entity;
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

        public async Task<GetTagDto> GetTagById(Guid id)
        {
            return (await _tagRepository.FindOneAsync(t => t.Id == id)).Adapt<GetTagDto>();
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
    }
}
