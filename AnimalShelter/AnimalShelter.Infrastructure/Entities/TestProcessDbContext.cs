using AnimalShelter.Infrastructure.Entities.Main;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AnimalShelter.Infrastructure.Entities
{
    public class TestProcessDbContext : DbContext
    {
        public TestProcessDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-42053LG\\SQLEXPRESS,1433;Initial Catalog=TestIT;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
