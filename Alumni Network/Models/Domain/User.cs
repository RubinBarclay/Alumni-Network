using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.Domain
{
    public class User : BaseEntity
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string Sub { get; set; } = null!;

        [Url]
        public string? PictureUrl { get; set; }

        [MaxLength(250)]
        public string? Status { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [MaxLength(250)]
        public string? FunFact { get; set; }

        // One-to-many relationship with Post
        public ICollection<Post> Posts { get; set; } = new List<Post>();

        // Many-to-many relationship with Group
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
