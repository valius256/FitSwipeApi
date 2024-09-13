using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.Users;
using LinqKit;
using Mapster;
using System.Dynamic;

namespace FitSwipe.BusinessLogic.Services.Users
{
    public class UserServices : IUserServices
    {
        private readonly IFirebaseAuthServices _firebaseAuthServices;
        private readonly IUserRepository _userRepository;
        public UserServices(IFirebaseAuthServices firebaseAuthServices, IUserRepository userRepository)
        {
            _firebaseAuthServices = firebaseAuthServices;
            _userRepository = userRepository;
        }
        public async Task<PagedResult<GetUserDto>> GetUserPaged(PagingModel<QueryUserDto> pagingModel)
        {
            return (await _userRepository.GetUsersPaged(pagingModel)).Adapt<PagedResult<GetUserDto>>();
        }
        public async Task<PagedResult<GetUserWithTagDto>> GetUserPagedWithTags(PagingModel<QueryUserDto> pagingModel)
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
        public async Task<PagedResult<GetUserWithTagDto>> GetMatchedUserPagedWithTagsOrdered(List<Guid> tagIds, int page, int limit)
        {
            var result = await _userRepository.GetMatchedPTOrdered(tagIds, page, limit);
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
        public async Task<User> GetUserByIdRequired(string id)
        {
            var user = await _userRepository.FindOneAsync(u => u.FireBaseId == id);
            if (user == null)
            {
                throw new DataNotFoundException("User not found");
            }
            return user;
        }
        public async Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos)
        {
            var UserFirebaseId = await _firebaseAuthServices.RegisterUserWithFirebase(registerDtos);


            //var userSaveInDb = 

            var userResponseModel = new GetUserProfileResponse()
            {
                DateOfBirth = registerDtos.DateOfBirth,
                Email = registerDtos.Email,
                Gender = registerDtos.Gender,
                Height = registerDtos.Height,
                Password = registerDtos.Password,
                Weight = registerDtos.Weight
            };

            return userResponseModel;
        }
    }
}
