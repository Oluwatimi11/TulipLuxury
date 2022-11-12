using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using TulipLuxury.Helpers.Contracts;
using TulipLuxury.Models;
using TulipLuxury.Data.ContractsRepo;

namespace TulipLuxury.Data
{
    public class CarRepository : ICarRepository
    {

        private readonly IReadWriteToJson _readWriteToJson;

        public CarRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }

        public async Task<List<CarModel>> GetAllCars()
        {
            var cars = await _readWriteToJson.ReadJson<CarModel>("Cars.json");
            return cars;
        }

        public async Task<CarModel> GetCarById(string CarId)
        {
            var cars = await GetAllCars();
            var car = cars.FirstOrDefault(x => x.Id == CarId);
            return car;
        }

    }
}

