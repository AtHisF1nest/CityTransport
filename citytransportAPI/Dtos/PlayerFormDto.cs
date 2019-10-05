using System.ComponentModel.DataAnnotations;

namespace citytransportAPI.Dtos
{
    public class PlayerFormDto
    {
        public string Email { get; set; }
        [Required]
        [MinLength(3)]
        public string Login { get; set; }
        [Required]
        [MinLength(5)]
        public string Password { get; set; }
    }
}