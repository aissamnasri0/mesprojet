using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class MvcSchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public MvcSchoolContext() { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BOR-12XVSG3;Database=School;Trusted_Connection=True;trustServerCertificate=true;");
        }
    }
}
