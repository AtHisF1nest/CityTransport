using System;
using Core.Data.Models.Enums;

namespace citytransportAPI.Dtos
{
    [Serializable]
    public class VehicleDto
    {
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Cost { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public decimal Fuel { get; set; }
        public PlayerDto Owner { get; set; }
        public string SourcePath { get; set; }
    }
}