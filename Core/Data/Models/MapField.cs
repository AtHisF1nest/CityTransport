using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Data.Models.Enums;

namespace Core.Data.Models
{
    public class MapField
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ElementType ElementType { get; set; }

        [ForeignKey(nameof(PhotoId))]
        public virtual Photo Photo { get; set; }
        public int? PhotoId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City InCity { get; set; }
        public int CityId { get; set; }
        public int GridX { get; set; }
        public int GridY { get; set; }
        public int GridWidth { get; set; } = 1;
        public int GridHeight { get; set; } = 1;
        public bool Visible { get; set; }
    }
}