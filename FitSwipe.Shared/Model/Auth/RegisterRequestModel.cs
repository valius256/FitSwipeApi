using FitSwipe.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace FitSwipe.Shared.Model.Auth
{
    public class RegisterRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Email is required.")]
        // [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }

        // [Required(ErrorMessage = "Phone number is required.")]
        // [RegularExpression(@"(84|0[3|5|7|8|9])[0-9]{8}", ErrorMessage = "Invalid phone number format.")]
        public string? Phone { get; set; }
        
        // [Required(ErrorMessage = "Date of birth is required.")]
        // [CustomValidation(typeof(DateOfBirthValidator), nameof(DateOfBirthValidator.IsValidDateOfBirth))]
        // public DateTime DateOfBirth { get; set; }

        public Role Role { get; set; }
        
    }

    public static class DateOfBirthValidator
    {
        public static ValidationResult IsValidDateOfBirth(DateTime dateOfBirth, ValidationContext context)
        {
            if (dateOfBirth >= DateTime.Today)
            {
                return new ValidationResult("Date of birth cannot be today or a future date.");
            }
            return ValidationResult.Success!;
        }
    }

}
