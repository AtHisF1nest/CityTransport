using System;

namespace citytransportAPI.Dtos
{
    [Serializable]
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int Population { get; set; }
        public int Money { get; set; }
        public PlayerDto Owner { get; set; }
    }
}