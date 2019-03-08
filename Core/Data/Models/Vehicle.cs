using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Data.Models.Enums;

namespace Core.Data.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime Created { get; set; }
        public decimal Cost { get; set; }
        public decimal Speed { get; set; }
        public int Capacity { get; set; }
        public decimal Fuel { get; set; }
        
        [ForeignKey(nameof(OwnerId))]
        public Player Owner { get; set; }
        public int OwnerId { get; set; }
    }
}