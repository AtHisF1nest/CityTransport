using System.Collections.Generic;
using citytransportAPI.Repositories.Interfaces;
using citytransportAPI.Services.Interfaces;
using Core.Data.Models;

namespace citytransportAPI.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetPlayerVehicles(int playerId)
        {
            return _vehicleRepository.GetPlayerVehicles(playerId);
        }

        public List<Vehicle> GetAllAvailableVehicles()
        {
            return _vehicleRepository.GetAllAvailableVehicles();
        }
    }
}