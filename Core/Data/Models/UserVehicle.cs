using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Data.Models
{
    public class UserVehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Player Owner { get; set; }
        public int OwnerId { get; set; }

        public DateTime Bought { get; set; }
    }
}