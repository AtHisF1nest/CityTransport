using citytransportAPI.Repositories.Interfaces;
using Core.Data.Models;
using System.Linq;

namespace citytransportAPI.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DataContext _dataContext;
        public PlayerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        public Player GetPlayer(int id)
        {
            var query = from pl in _dataContext.Players
                        where pl.Id == id
                        select pl;
            
            var item = query.FirstOrDefault();

            return item;
        }

        public Player GetPlayer(string login)
        {
            var query = from pl in _dataContext.Players
                        where pl.Login == login
                        select pl;
            
            var item = query.FirstOrDefault();

            return item;
        }
    }
}