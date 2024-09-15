using FirebaseAdmin.Auth;
using FitSwipe.BusinessLogic.Interfaces.Auth;
using FitSwipe.BusinessLogic.Interfaces.Sender;
using FitSwipe.BusinessLogic.Models.User;
using FitSwipe.DataAccess.Model.Enum;
using FitSwipe.Shared.Exceptions;
using FitSwipe.Shared.Model.Auth;


namespace FitSwipe.BusinessLogic.Services.Auth
{
    public class FirebaseAuthServices : IFirebaseAuthServices
    {
        private readonly IEmailServices _emailServices;

        public FirebaseAuthServices(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        public async Task<bool> GenerateVerificationEmailAsync(string email)
        {


            var link = await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(email);

            var toAddress = new List<string> { email };
            var emailParams = new Dictionary<string, string>()
            {
                { "UserName", $"{email}" },
                {"VerificationLink", $"{link}"}
            };

            await _emailServices.SendAsync(EmailType.Register_Mail, toAddress, new List<string>(), emailParams,
                false);
            return true;
        }


        public async Task<RegisterAuthModel> RegisterUserWithFirebaseAsync(RegisterRequestModel registerRequestModel)
        {
            var userForFireBaseAuth = new UserRecordArgs
            {
                Email = registerRequestModel.Email,
                Password = registerRequestModel.Password,
                DisplayName = registerRequestModel.Email,
            };

            var userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(userForFireBaseAuth);
            var link = await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(userRecord.Email);

            return new RegisterAuthModel()
            {
                RegisterLink = link,
                UserFirebaseId = userRecord.Uid
            };
        }

        public async Task<string?> ForgotPasswordAsync(string email)
        {
            if (await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email) == null)
            {
                return null;
            }

            return await FirebaseAuth.DefaultInstance.GeneratePasswordResetLinkAsync(email);
        }

        public async Task VerifyFirebaseToken(string token)
        {
            var firebaseToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
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
