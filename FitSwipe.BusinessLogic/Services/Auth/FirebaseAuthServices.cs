using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;


namespace FitSwipe.BusinessLogic.Services.Auth
{
    public class FirebaseAuthServices : IFirebaseAuthServices
    {
        public async Task<string> RegisterUserWithFirebase(RegisterRequestModel registerRequestModel)
        {
            var userForFireBaseAuth = new UserRecordArgs
            {
                Email = registerRequestModel.Email,
                Password = registerRequestModel.Password,
                DisplayName = registerRequestModel.Email,
                PhoneNumber = registerRequestModel.PhoneNumber,
            };

            var userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(userForFireBaseAuth);
            await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(userRecord.Email);
            return userRecord.Uid;
        }

        public async Task<string> ForgotPassword(string email)
        {
            return await FirebaseAuth.DefaultInstance.GeneratePasswordResetLinkAsync(email);
        }

        public async Task SetCustomClaimsAsync(string userId, Dictionary<string, object> claims)
        {
            await FirebaseAuth.DefaultInstance.SetCustomUserClaimsAsync(userId, claims);
        }

        public async Task<bool> DeleteUserAsync(string? email)
        {
            var user = await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email);
            if (user == null)
                throw new ModelException("User not found", "not found", "");

            await FirebaseAuth.DefaultInstance.DeleteUserAsync(user.Uid);
            return true;
        }
    }
}
