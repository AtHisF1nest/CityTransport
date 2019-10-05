using System;
using System.Collections.Generic;
using Core.Data.Models;

namespace citytransportAPI.Dtos
{
    [Serializable]
    public class PlayerInfoDto
    {
        public PlayerDto Player { get; set; }
        public CityDto CurrentCity { get; set; }
        public List<VehicleDto> AvailableVehicles { get; set; }
    }
}