using System.Collections.Generic;
using System.Threading.Tasks;
using TulipLuxury.Models;

namespace TulipLuxury.Data.ContractsRepo
{
    public interface ICarRepository
    {
        Task<List<CarModel>> GetAllCars();
        Task<CarModel> GetCarById(string CarId);
    }
}