using Core.Data.Models;

namespace citytransportAPI.Repositories.Interfaces
{
    public interface ICityRepository
    {
        City GetCity(int id);
    }
}