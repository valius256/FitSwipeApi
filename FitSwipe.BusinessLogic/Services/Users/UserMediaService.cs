using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Medias;
using FitSwipe.Shared.Exceptions;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSwipe.BusinessLogic.Services.Users
{
    public class UserMediaService : IUserMediaService
    {
        private readonly IUserMediaRepository _userMediaRepository;
        private readonly IUserServices _userServices;
        public UserMediaService(IUserMediaRepository userMediaRepository, IUserServices userServices)
        {
            _userMediaRepository = userMediaRepository;
            _userServices = userServices;
        }
        public async Task<GetUserMediaDto> GetUserMediaRequiredById(Guid userMediaId)
        {
            var userMedia = await _userMediaRepository.FindOneWithNoTrackingAsync(um => um.Id == userMediaId);
            if (userMedia == null)
            {
                throw new DataNotFoundException("User Media is not found");
            }
            return userMedia.Adapt<GetUserMediaDto>();
        }
        public async Task<GetUserMediaDto> CreateUserMediaAsync(CreateUserMediaDto userMediaDto, string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            var userMedia = userMediaDto.Adapt<UserMedia>();
            userMedia.UserId = userId;
            var createdUser = await _userMediaRepository.AddAsync(userMedia);
            return createdUser.Adapt<GetUserMediaDto>();
        }

        public async Task DeleteUserMediaAsync(Guid userMediaId, string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            
            var existedMedia = await GetUserMediaRequiredById(userMediaId);

            if (existedMedia.UserId != userId && user.Role != Shared.Enum.Role.Operator)
            {
                throw new ForbiddenException("You do not have permission to do this function");
            }

            await _userMediaRepository.DeleteAsync(userMediaId);
        }

        public async Task<GetUserMediaDto> UpdateUserMediaAsync(UpdateUserMediaDto userMediaDto, string userId)
        {
            var user = await _userServices.GetUserByIdRequiredAsync(userId);
            var existedMedia = await GetUserMediaRequiredById(userMediaDto.Id);
            if (existedMedia.UserId != userId && user.Role != Shared.Enum.Role.Operator)
            {
                throw new ForbiddenException("You do not have permission to do this function");
            }
            existedMedia.Description = userMediaDto.Description;

            await _userMediaRepository.UpdateAsync(existedMedia.Adapt<UserMedia>());
            return existedMedia.Adapt<GetUserMediaDto>();
        }
    }
}
