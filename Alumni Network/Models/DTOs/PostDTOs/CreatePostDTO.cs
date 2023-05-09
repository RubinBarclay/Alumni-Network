using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.DTOs.PostDTOs
{
    public class CreatePostDTO
    {
        [Required, MaxLength(255)]
        public string Title { get; set; }

        [Required, MaxLength(2000)]
        public string Body { get; set; }

        // One-to-many relationship with User
        // public int AuthorId { get; set; } // or get this from JWT?

        // Self referencing one-to-many relationship with Post (to determine original post)
        public int? ReplyParentId { get; set; } // Or create different dto for replies?

        // One-to-many relationship with Group
        public int TargetGroupId { get; set; }
    }
}
