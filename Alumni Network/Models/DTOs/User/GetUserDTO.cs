using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.DTOs.User
{
    public class GetUserDTO
    {
        [Url]
        public string Location { get; set; }
    }
}
