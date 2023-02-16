using Microsoft.EntityFrameworkCore;

namespace apiuser
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Produit> produits { get; set; }
        


        public UserContext()
        {
            Database.EnsureCreated();
            // var databaseCreator = (Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator);
			// databaseCreator.Createtable();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=tpapi;User=root;Password=123456");
        }

    }
}