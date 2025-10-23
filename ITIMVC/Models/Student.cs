using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ITIMVC.Models
{
    public class Student
    {
        [Key]
        public int ssn { get; set; }
        public string name { get; set; } = string.Empty;
        public int age { get; set; }
        public string address { get; set; } = string.Empty;
        public string image { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
    }
}