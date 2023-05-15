using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.DTOs.PostDTOs
{
    public class EditPostDTO
    {
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Body { get; set; }
    }
}
