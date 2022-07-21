using EconomyProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EconomyProject.Data.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CUUF6NH;database=EconomyDb; integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
    }
}
