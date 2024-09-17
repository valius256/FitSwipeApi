using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.DataAccess.Model.Paging;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Tags;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Enum;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.Users;
using Mapster;

namespace FitSwipe.BusinessLogic.Services.Users
{
    public class UserServices : IUserServices
    {
        private readonly IFirebaseAuthServices _firebaseAuthServices;
        private readonly IUserRepository _userRepository;
        private readonly IEmailServices _emailServices;

        public UserServices(IFirebaseAuthServices firebaseAuthServices, IUserRepository userRepository, IEmailServices emailServices)
        {
            _firebaseAuthServices = firebaseAuthServices;
            _userRepository = userRepository;
            _emailServices = emailServices;
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

        public async Task<bool> ForgotPassword(string email)
        {

            var resetPasswordLink = await _firebaseAuthServices.ForgotPasswordAsync(email);
            if (resetPasswordLink == null)
            {
                return false;
            }

            var emailParams = new Dictionary<string, string>()
            {
                { "Name", $"{email}" },
                {"ResetPasswordLink", $"{resetPasswordLink}"}
            };
            var toAddress = new List<string>() { email };
            await _emailServices.SendAsync(EmailType.Forgot_Password, toAddress, new List<string>(), emailParams,
                false);



            return true;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            var userListModal = await _userRepository.GetAllAsync();
            return userListModal.Adapt<List<User>>();
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _userRepository.FindOneAsync(l => l.Email == email);
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


        public async Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos)
        {
            var registerAuthModel = await _firebaseAuthServices.RegisterUserWithFirebaseAsync(registerDtos);

            // Map Register DTO to User entity
            var userEntity = registerDtos.Adapt<User>();

            // Populate additional fields for the User entity
            userEntity.FireBaseId = registerAuthModel.UserFirebaseId;
            userEntity.Role = registerDtos.Role;
            userEntity.UserName = registerDtos.Email;
            userEntity.Status = UserStatus.Active;

            // Add the User entity to the database
            await _userRepository.AddAsync(userEntity);


            var toAddress = new List<string> { registerDtos.Email };
            var emailParams = new Dictionary<string, string>()
            {
                { "Name", $"{registerDtos.Email}" },
                {"VerificationLink", $"{registerAuthModel.RegisterLink}"}
            };

            await _emailServices.SendAsync(EmailType.Register_Mail, toAddress, new List<string>(), emailParams,
                false);


            var userResponseModel = new GetUserProfileResponse()
            {
                Email = registerDtos.Email,
                Password = registerDtos.Password,
                Role = registerDtos.Role,
                CreateDate = userEntity.CreatedDate
            };

            return userResponseModel;
        }
    }
}
