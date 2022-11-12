using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TulipLuxuryCore.Contracts;
using System.Linq;
using TulipLuxury.Data.ContractsRepo;
using TulipLuxury.Models;

namespace TulipLuxuryCore.Implementations
{
    public class CarService : ICarService
    {

        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<CarModel>> GetAllCars()
        {
            return await _carRepository.GetAllCars();
        }

        public async Task<CarModel> GetCarById(string CarId)
        {
            return await _carRepository.GetCarById(CarId);
        }

    }
}

