using citytransportAPI.Cache;
using citytransportAPI.Dtos;
using citytransportAPI.Repositories.Interfaces;
using citytransportAPI.Services.Interfaces;
using Core.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace citytransportAPI.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICityService _cityService;
        private readonly SessionCache _sessionCache;
        private readonly IVehicleService _vehicleService;

        public PlayerService(IPlayerRepository playerRepository, IHttpContextAccessor httpContextAccessor, ICityService cityService,
            SessionCache sessionCache, IVehicleService vehicleService)
        {
            _sessionCache = sessionCache;
            _vehicleService = vehicleService;
            _playerRepository = playerRepository;
            _httpContextAccessor = httpContextAccessor;
            _cityService = cityService;
        }

        public Player GetPlayer(int id)
        {
            return _playerRepository.GetPlayer(id);
        }

        public Player GetPlayer(string login)
        {
            return _playerRepository.GetPlayer(login);
        }

        public PlayerInfoDto GetPlayerInfo(int lastCityId = 1)
        {
            PlayerInfoDto res = _sessionCache.PlayerInfo;
            if (res.Player != null)
                return res;

            var currentPlayer = this.GetPlayer(_httpContextAccessor.HttpContext.User.Identity.Name);
            //todo: automapper na playera i tu dać playera
            res.Player = new PlayerDto()
            {
                Id = currentPlayer.Id,
                Name = currentPlayer.Login,
                Money = currentPlayer.Money,
                Age = (int)(DateTime.Now - currentPlayer.Created).TotalDays
            };
            var currentCity = _cityService.GetCity(lastCityId);
            res.CurrentCity = new CityDto() {
                Id = currentCity.Id,
                Name = currentCity.Name,
                Created = currentCity.Created,
                Money = (int)currentCity.Money,
                //todo: automapper na playera i tu dać playera
                Owner = null,
                Population = currentCity.Population
            };
            res.AvailableVehicles = new List<VehicleDto>();
            _vehicleService.GetPlayerVehicles(currentPlayer.Id).ForEach(x => {
                res.AvailableVehicles.Add(new VehicleDto() {
                    Id = x.Id,
                    Owner = res.Player,
                    Capacity = x.Capacity,
                    Cost = x.Cost,
                    Fuel = x.Fuel,
                    Speed = x.Speed,
                    VehicleType = x.VehicleType,
                    SourcePath = x.Photo.SourcePath
                });
            });

            _sessionCache.PlayerInfo = res;

            return res;
        }
    }
}