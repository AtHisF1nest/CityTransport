using Core.Data.Models.Enums;

namespace citytransportAPI.Dtos
{
    public class MapFieldDto
    {
        public string Name { get; set; }
        public int XCord { get; set; }
        public int YCord { get; set; }
        public int GridWidth { get; set; }
        public int GridHeight { get; set; }
        public string PhotoPath { get; set; }
        public ElementType ElementType { get; set; }
    }
}