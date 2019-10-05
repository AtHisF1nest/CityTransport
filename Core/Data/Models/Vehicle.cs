using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Data.Models.Enums;

namespace Core.Data.Models
{
    [Serializable]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Cost { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public decimal Fuel { get; set; }
        
        [ForeignKey(nameof(PhotoId))]
        public virtual Photo Photo { get; set; }
        public int? PhotoId { get; set; }
    }
}