using System;
namespace TulipLuxury.Models
{
	public class CustomerModel
	{
        public string Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public CustomerModel()
        {

        }
    }
}

