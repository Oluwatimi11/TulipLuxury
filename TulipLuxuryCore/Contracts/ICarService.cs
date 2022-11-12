using System.Collections.Generic;
using System.Threading.Tasks;
using TulipLuxury.Models;

namespace TulipLuxuryCore.Contracts
{
    public interface ICarService
    {
        Task<List<CarModel>> GetAllCars();
        Task<CarModel> GetCarById(string CarId);
    }
}