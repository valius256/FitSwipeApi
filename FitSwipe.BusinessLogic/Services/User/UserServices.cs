using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.User;
using FitSwipe.Shared.Model.Auth;
using FitSwipe.Shared.Model.User;

namespace FitSwipe.BusinessLogic.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly IFirebaseAuthServices _firebaseAuthServices;
        public UserServices(IFirebaseAuthServices firebaseAuthServices)
        {
            _firebaseAuthServices = firebaseAuthServices;
        }

        public async Task<GetUserProfileResponse> RegisterUser(RegisterRequestModel registerDtos)
        {
            var UserFirebaseId = await _firebaseAuthServices.RegisterUser(registerDtos);

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
