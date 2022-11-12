using System;
using System.Threading.Tasks;
using TulipLuxury.Models;
using TulipLuxury.ViewModel;

namespace TulipLuxuryCore.Contracts
{
	public interface ICustomerService
	{
		Task<CustomerModel> LogIn(string email, string password);
		Task<CustomerModel> SignUp(SignUpViewModel model);
	}
}

