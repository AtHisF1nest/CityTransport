using citytransportAPI.Repositories.Interfaces;
using citytransportAPI.Services.Interfaces;
using Core.Data.Models;

namespace citytransportAPI.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public City GetCity(int id)
        {
            return _cityRepository.GetCity(id);
        }
    }
}