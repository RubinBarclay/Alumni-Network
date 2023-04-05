using System.ComponentModel.DataAnnotations;

namespace Alumni_Network.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string Picture { get; set; }
        [Required, MaxLength(250)]
        public string Status { get; set; }
        [Required, MaxLength(500)]
        public string Bio { get; set; }
        [Required, MaxLength(250)]
        public string FunFact { get; set; }
    }
}
