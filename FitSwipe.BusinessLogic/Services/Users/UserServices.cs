using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.UploadDowloads;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Exceptions;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace FitSwipe.BusinessLogic.Services.Users
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailServices _emailServices;

        public UserServices(IUserRepository userRepository, IEmailServices emailServices)
        {
            _userRepository = userRepository;
            _emailServices = emailServices;
        }

        public async Task<PagedResult<GetUserDto>> GetUserPagedAsync(PagingModel<QueryUserDto> pagingModel)
        {
            return (await _userRepository.GetUsersPaged(pagingModel)).Adapt<PagedResult<GetUserDto>>();
        }
        public async Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTagsAsync(PagingModel<QueryUserDto> pagingModel)
        {
            var result = await _userRepository.GetUsersPagedWithTags(pagingModel);
            var mappedResult = result.Adapt<PagedResult<GetUserWithTagDto>>();
            foreach (var item in mappedResult.Items)
            {
                var itemData = result.Items.FirstOrDefault(u => u.FireBaseId == item.FireBaseId);
                if (itemData != null)
                {
                    item.Tags = itemData.UserTags.Select(u => u.Tag.Adapt<GetTagDto>()).ToList();
                }
            }
            return mappedResult;
        }



        public async Task<List<User>> GetAllUserAsync()
        {
            var userListModal = await _userRepository.GetAllAsync();
            return userListModal.Adapt<List<User>>();
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _userRepository.FindOneAsync(l => l.Email == email);
        }

        public async Task<PagedResult<GetUserWithTagDto>> GetMatchedUserPagedWithTagsOrderedAsync(List<Guid> tagIds, string userId, int page, int limit)
        {
            var result = await _userRepository.GetMatchedPTOrdered(tagIds, userId, page, limit);
            var mappedResult = result.Adapt<PagedResult<GetUserWithTagDto>>();
            foreach (var item in mappedResult.Items)
            {
                var itemData = result.Items.FirstOrDefault(u => u.FireBaseId == item.FireBaseId);
                if (itemData != null)
                {
                    item.Tags = itemData.UserTags.Select(u => u.Tag.Adapt<GetTagDto>()).ToList();
                }
            }
            return mappedResult;
        }


        /// <summary>
        /// Retrieves a user from the database by their Firebase ID. If the user is not found in the database,
        /// it will attempt to fetch the user record from Firebase, map it to a user entity, and store it in the database.
        /// </summary>
        /// <param name="id">The Firebase ID of the user to retrieve.</param>
        /// <returns>
        /// The <see cref="User"/> entity if found, either from the database or Firebase.
        /// </returns>
        /// <exception cref="DataNotFoundException">
        /// Thrown if the user does not exist in both the local database and Firebase.
        /// </exception>
        public async Task<User> GetUserByIdRequiredAsync(string id)
        {
            var user = await _userRepository.FindOneAsync(u => u.FireBaseId == id);
            if (user == null)
            {
                try
                {
                    var recordToFetch = await FirebaseAuth.DefaultInstance.GetUserAsync(id);
                    if (recordToFetch == null)
                    {
                        throw new DataNotFoundException("User not found");
                    }
                    else
                    {
                        user = FetchUserRecordToUserEntity(recordToFetch);
                        await _userRepository.AddAsync(user);
                    }
                }
                catch (FirebaseAuthException)
                {
                    throw new DataNotFoundException("User not found");
                }
            }
            return user;
        }



        private User FetchUserRecordToUserEntity(UserRecord recordToFetch)
        {
            var userEntitty = recordToFetch.Adapt<User>();
            userEntitty.Id = Guid.NewGuid();
            userEntitty.Password = "defaultPassword";
            userEntitty.Phone = recordToFetch.PhoneNumber != null ? recordToFetch.PhoneNumber : "0935333333";
            userEntitty.FireBaseId = recordToFetch.Uid;
            userEntitty.UserName =
                recordToFetch.DisplayName != null ? recordToFetch.DisplayName : recordToFetch.Email;

            return userEntitty;
        }

        public async Task<GetUserDto> GetSimpleUser(string userFirebaseId)
        {
            var userEntity = await GetUserByIdRequiredAsync(userFirebaseId);
            return (userEntity.Adapt<GetUserDto>());
        }
        public async Task<GetUserDetailDto> GetUserDetail(string userFirebaseId)
        {
            var user = await GetUserByIdRequiredAsync(userFirebaseId);
            var userDetail = await _userRepository.GetUserDetailById(userFirebaseId);

            var mappedUser = (userDetail.Adapt<GetUserDetailDto>());
            mappedUser.Tags = userDetail!.UserTags.Select(t => t.Tag).Adapt<List<GetTagDto>>();
            return mappedUser;
        }

        public async Task UpdatePTDegreeAsync(string userId, UpdateImageUrlDto updateImageUrlDto)
        {
            var user = await GetUserByIdRequiredAsync(userId);
            user.PTDegreeImageUrl = updateImageUrlDto.Url;
            await _userRepository.UpdateAsync(user);
        }
        public async Task SetupProfileAsync(string userId, SetupProfileDto setupProfileDto)
        {
            var user = await GetUserByIdRequiredAsync(userId);
            var updatedUser = setupProfileDto.Adapt(user);
            if (setupProfileDto.DateOfBirth.HasValue)
            {
                user.DateOfBirth = DateTime.SpecifyKind(setupProfileDto.DateOfBirth.Value, DateTimeKind.Utc);
            }
            await _userRepository.UpdateAsync(updatedUser);
        }

        public async Task<User?> AddUserAsync(User user)
        {
            var userInDb = await _userRepository.FindOneAsync(u => u.FireBaseId == user.FireBaseId);
            if (user != null)
            {
                user.Id = Guid.NewGuid();
                await _userRepository.AddAsync(user);
                return user;
            }
            else
            {
                throw new BadRequestException("FirebaseId had existed");
            }
        }

        public async Task UpdateAvatarImage(string userId, UpdateUserAvatarDtos updateUserAvatarDtos)
        {
            var currUser = await GetUserByIdRequiredAsync(userId);
            if (currUser != null)
            {
                throw new DataNotFoundException("User not found");
            }

            var result = await _userRepository.Where(l => l.FireBaseId == userId)
                .ExecuteUpdateAsync(setter => setter.SetProperty(b => b.AvatarUrl, updateUserAvatarDtos.ImageAvatarUrl));

        }
    }
}
