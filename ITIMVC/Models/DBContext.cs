using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
            
        }
        public DbSet<Student> Students { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5TI5SLQ;Database=MVCDay1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
