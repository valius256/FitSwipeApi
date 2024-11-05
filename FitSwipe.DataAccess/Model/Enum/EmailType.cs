namespace FitSwipe.DataAccess.Model.Enum;

public static class EmailType
{
    public const string Register_Mail = "Register_Mail"; // params : email, verifycationLink from firebase
    public const string Forgot_Password = "Forgot_Password"; // params : email, forgotPasswordLink from firebase
    public const string Payment_Success = "Payment_Success"; // params : [Name], [Amount], [PaymentDate]
}