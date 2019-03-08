using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Data.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int Population { get; set; }
        public decimal Money { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public virtual Player Owner { get; set; }
        public int OwnerId { get; set; }
    }
}