using Core.Data.Models;

namespace citytransportAPI.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetPlayer(int id);
        Player GetPlayer(string login);
        Dtos.PlayerInfoDto GetPlayerInfo(int lastCityId = 1);
    }
}