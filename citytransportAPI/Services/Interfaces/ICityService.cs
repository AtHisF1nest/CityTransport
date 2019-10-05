using Core.Data.Models;

namespace citytransportAPI.Services.Interfaces
{
    public interface ICityService
    {
        City GetCity(int id);
    }
}