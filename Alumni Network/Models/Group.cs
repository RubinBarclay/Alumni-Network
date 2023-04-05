using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public bool IsPrivate { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
