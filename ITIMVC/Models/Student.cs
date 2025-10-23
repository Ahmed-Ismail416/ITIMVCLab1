using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string?Name { get; set; }
        [Range(15,25)]
        public int Age { get; set; }

        public string? Address { get; set; }
        
        public string? Image { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
