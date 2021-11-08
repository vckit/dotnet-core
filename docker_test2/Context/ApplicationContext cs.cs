using Microsoft.EntityFrameworkCore;

namespace docker_test2.Context
{

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=@Generally090;Persist Security Info=True;User ID=sa;Initial Catalog=thevckitdb;Data Source=localhost");
        }
    }

}