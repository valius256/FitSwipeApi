using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Users;
using FitSwipe.DataAccess.Model.Entity;
using FitSwipe.DataAccess.Repository.Intefaces;
using FitSwipe.Shared.Dtos.Users;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.Users;
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
