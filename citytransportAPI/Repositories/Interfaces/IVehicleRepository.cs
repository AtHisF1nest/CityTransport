using System.Collections.Generic;
using Core.Data.Models;

namespace citytransportAPI.Repositories.Interfaces
{
    public interface IVehicleRepository : IRepository
    {
        List<Vehicle> GetAllAvailableVehicles();
        List<Vehicle> GetPlayerVehicles(int playerId);
    }
}