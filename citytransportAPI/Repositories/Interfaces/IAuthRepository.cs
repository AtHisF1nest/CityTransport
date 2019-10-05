using System.Threading.Tasks;
using Core.Data.Models;

namespace citytransportAPI.Repositories.Interfaces
{
    public interface IAuthRepository : IRepository
    {
         Task<Player> Register(Player player, string password);
         Task<Player> Login(string login, string password);
         Task<bool> PlayerExists(string login);
    }
}