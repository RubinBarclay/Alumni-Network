namespace Alumni_Network.Models.DTOs.PostDTOs
{
    public class GetPostDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        // One-to-many relationship with User
        public int AuthorId { get; set; }

        // Self referencing one-to-many relationship with Post (to determine original post)
        public int? ReplyParentId { get; set; }

        // Convert ICollection of replies to list of reply ids
        public List<int> Replies { get; set; } = new List<int>();

        public int TargetGroupId { get; set; }
    }
}
