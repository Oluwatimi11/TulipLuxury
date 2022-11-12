using System;
using System.ComponentModel.DataAnnotations;

namespace TulipLuxury.ViewModel
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(100)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(100)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter your valid email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(10)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm passwprd does not match")]
        public string ConfirmPassword { get; set; }
    }
}

