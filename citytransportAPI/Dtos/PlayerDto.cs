using System;

namespace citytransportAPI.Dtos
{
    [Serializable]
    public class PlayerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int Age { get; set; }
    }
}