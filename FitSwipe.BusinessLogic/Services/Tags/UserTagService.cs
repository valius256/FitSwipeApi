
using FitSwipe.BusinessLogic.Interfaces.Tags;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Exceptions;
using Mapster;
using Org.BouncyCastle.Crypto;
using System.Linq;

namespace FitSwipe.BusinessLogic.Services.Tags
{
    public class UserTagService : IUserTagService
    {
        private readonly IUserTagRepository _userTagRepository;
        private readonly IUserServices _userServices;
        private readonly ITagService _tagService;

        public UserTagService(IUserTagRepository userTagRepository, ITagService tagService, IUserServices userServices)
        {
            _userTagRepository = userTagRepository;
            _tagService = tagService;
            _userServices = userServices;
        }

        public async Task UpsertUserTags(string userId, UpsertUserTagDto upsertUserTagDto)
        {
            await _userServices.GetUserByIdRequired(userId);
            var oldTagIds = (await GetsTagByUserId(userId)).Select(t => t.Id);
            // Add new tags that are not in the old tags
            foreach (var newTagId in upsertUserTagDto.NewTagIds)
            {
                if (!oldTagIds.Contains(newTagId))
                {
                    await AddUserTag(userId, newTagId);
                }
            }
            // Remove old tags that are not in the new tag list
            foreach (var oldTag in oldTagIds)
            {
                if (!upsertUserTagDto.NewTagIds.Contains(oldTag))
                {
                    await DeleteUserTag(userId, oldTag);
                }
            }
        }
        public async Task<List<GetTagDto>> GetsTagByUserId(string userId)
        {
            var userTags = await _userTagRepository.GetUserTagWithTagByUserIdAsync(userId);
            return userTags.Select(userTag => userTag.Tag.Adapt<GetTagDto>()).ToList();
        }
        public async Task<UserTag> AddUserTag(string userId, Guid tagId)
        {
            await _userServices.GetUserByIdRequired(userId);
            await _tagService.GetTagByIdRequired(tagId);
            return await _userTagRepository.AddAsync(new UserTag() { UserId = userId, TagId = tagId });
        }

        public async Task DeleteUserTag(string userId, Guid tagId)
        {
            var existedUserTag = await _userTagRepository.FindOneAsync(ut => ut.UserId ==  userId && ut.TagId == tagId);
            if (existedUserTag == null)
            {
                throw new DataNotFoundException("User tag not found");
            }
            await _userTagRepository.DeleteAsync(existedUserTag.Id);
            
        }
    }
}
