using System;
using System.Linq;
using System.Threading.Tasks;
using TulipLuxuryCore.Contracts;
using TulipLuxury.Data.ContractsRepo;
using TulipLuxury.Models;
using TulipLuxury.ViewModel;

namespace TulipLuxuryCore.Implementations
{
	public class CustomerService : ICustomerService
	{
        private readonly IAuthRepository _authRepository;

		public CustomerService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<CustomerModel> LogIn(string email, string password)
        {
            var customer = await _authRepository.LogIn(email, password);

            return customer;
        }

        public async Task<CustomerModel> SignUp(SignUpViewModel model)
        {
            var customer = await _authRepository.SignUp(model);

            return customer;
        }
    }
}