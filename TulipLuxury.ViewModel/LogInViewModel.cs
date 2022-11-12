using System;
using System.ComponentModel.DataAnnotations;

namespace TulipLuxury.ViewModel
{
	public class LogInViewModel
	{
		[Required(ErrorMessage = "Please enter your valid email address")]
		[Display(Name = "Email Address")]
		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter password")]
		[DataType(DataType.Password)]
		[StringLength(10)]
		public string Password { get; set; }

		public LogInViewModel(string email, string password)
        {
			Email = email;
			Password = password;
        }

		public LogInViewModel()
		{
			
		}
	}
}

