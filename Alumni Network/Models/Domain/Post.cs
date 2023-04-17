using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models.Domain
{
    public class Post : BaseEntity
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        [Required, MaxLength(2000)]
        public string Body { get; set; }

        // One-to-many relationship with User
        public int AuthorId { get; set; }
        public User Author { get; set; }

        // Self referencing one-to-many relationship with Post (to determine original post)
        public int? ReplyParentId { get; set; }
        public Post? ReplyParent { get; set; }

        // Self-referencing one-to-many relationship with Post (for replies)
        public ICollection<Post> Replies { get; set; } = new List<Post>();

        // One-to-many relationship with Group
        public int TargetGroupId { get; set; }
        public Group TargetGroup { get; set; }
    }
}
