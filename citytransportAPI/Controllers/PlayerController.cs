using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using citytransportAPI.Cache;
using citytransportAPI.Dtos;
using citytransportAPI.Services.Interfaces;
using Core.Data.Models;
using Core.Data.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace citytransportAPI.Controllers
{
    [Authorize]
    public class PlayerController : ApiControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly SessionCache _sessionCache;

        public PlayerController(IPlayerService playerService, SessionCache sessionCache)
        {
            _playerService = playerService;
            _sessionCache = sessionCache;
        }

        [HttpGet]
        public IActionResult GetPlayerInfo()
        {
            int lastCityId = _sessionCache.LastCityId;
            if(lastCityId == default(int))
                lastCityId = 1;

            PlayerInfoDto res =  _playerService.GetPlayerInfo(lastCityId);

            return Ok(res);
        }
    }
}