using ITIMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIMVC.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CompanyDb;Trusted_Connection=True;Encrypt=False;");
        }
        public DbSet<Student> Students { get; set; }

    }
}
