using System.Collections.Generic;
using Core.Data.Models;

namespace citytransportAPI.Services.Interfaces
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllAvailableVehicles();
        List<Vehicle> GetPlayerVehicles(int playerId);
    }
}