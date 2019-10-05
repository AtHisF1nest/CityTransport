using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Data.Models.Enums;

namespace Core.Data.Models
{
    public class Configuration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ConfigurationType ConfigurationType { get; set; }
        public string ConfigSerialized { get; set; }
    }
}