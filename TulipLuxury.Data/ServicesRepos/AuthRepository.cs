using System;
using System.Linq;
using System.Threading.Tasks;
using TulipLuxury.Data.ContractsRepo;
using TulipLuxury.Helpers.Contracts;
using TulipLuxury.Models;
using TulipLuxury.ViewModel;

namespace TulipLuxury.Data.ServicesRepos
{
    public class AuthRepository : IAuthRepository
    {

        private readonly IReadWriteToJson _readWriteToJson;
        private readonly ICustomerUtilities _customerUtilities;

        public AuthRepository(IReadWriteToJson readWriteToJson, ICustomerUtilities customerUtilities)
        {
            _readWriteToJson = readWriteToJson;
            _customerUtilities = customerUtilities;
        }

        public async Task<CustomerModel> LogIn(string email, string password)
        {
            var hashPassword = _customerUtilities.PasswordHash(password);

            var customers = await _readWriteToJson.ReadJson<CustomerModel>("Customers.json");

            var customer = customers.FirstOrDefault(x => x.Password == hashPassword && x.Email == email);

            return customer;
        }

        public async Task<CustomerModel> SignUp(SignUpViewModel model)
        {
            var hashPassword = _customerUtilities.PasswordHash(model.Password);
            var hashConfirmPassword = _customerUtilities.PasswordHash(model.ConfirmPassword);

            var customer = new CustomerModel()
            {
                Id = Guid.NewGuid().ToString(),
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Password = hashPassword,
                ConfirmPassword = hashConfirmPassword,
                IsActive = true,
                Created_at = DateTime.Now
            };
            try
            {
                await _readWriteToJson.WriteJson<CustomerModel>(customer, "Customers.json");
                return customer;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}

