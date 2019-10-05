using Core.Data.Models;

namespace citytransportAPI.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetPlayer(int id);
        Player GetPlayer(string login);
    }
}