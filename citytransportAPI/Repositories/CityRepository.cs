using citytransportAPI.Repositories.Interfaces;
using Core.Data.Models;
using System.Linq;

namespace citytransportAPI.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _dataContext;

        public CityRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public City GetCity(int id) 
        {
            var query = from ct in _dataContext.Cities
                        where ct.Id == id
                        select ct;

            var item = query.FirstOrDefault();

            return item;
        }
    }
}