using System.Collections.Generic;
using citytransportAPI.Repositories.Interfaces;
using Core.Data.Models;
using System.Linq;

namespace citytransportAPI.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _dataContext;

        public VehicleRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Vehicle> GetPlayerVehicles(int playerId)
        {
            var queryForPlayerVehicles = 
                from v in _dataContext.Vehicles
                join pV in _dataContext.UserVehicles 
                    on new { playerId, v.Id } equals new { playerId = pV.OwnerId, Id = pV.VehicleId }
                join photos in _dataContext.Photos on v.PhotoId equals photos.Id
                select new Vehicle() {
                    Id = v.Id,
                    Capacity = v.Capacity,
                    Cost = v.Cost,
                    Fuel = v.Fuel,
                    Photo = v.Photo,
                    PhotoId = v.PhotoId,
                    Speed = v.Speed,
                    VehicleType = v.VehicleType
                };

            var res = queryForPlayerVehicles.ToList();

            return res;
        }

        public List<Vehicle> GetAllAvailableVehicles()
        {
            var query = from v in _dataContext.Vehicles
                        select v;

            return query.ToList();
        }
    }
}