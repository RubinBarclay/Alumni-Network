using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.DTOs.User
{
    public class CreateUserDTO
    {
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        public string? Sub { get; set; } // will be set in the controller
    }
}
