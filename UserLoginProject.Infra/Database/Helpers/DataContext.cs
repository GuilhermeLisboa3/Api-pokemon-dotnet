using Microsoft.EntityFrameworkCore;
using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Infra.Database.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
