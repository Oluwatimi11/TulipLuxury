using System.Threading.Tasks;
using TulipLuxury.Models;
using TulipLuxury.ViewModel;

namespace TulipLuxury.Data.ContractsRepo
{
    public interface IAuthRepository
    {
        Task<CustomerModel> LogIn(string email, string password);
        Task<CustomerModel> SignUp(SignUpViewModel model);
    }
}