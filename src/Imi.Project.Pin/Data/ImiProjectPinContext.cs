using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Pin.Data
{
    public class ImiProjectPinContext : DbContext
    {
        public ImiProjectPinContext(DbContextOptions<ImiProjectPinContext> options)
            : base(options)
        {
        }

        public DbSet<Imi.Project.Pin.Models.Animal> Animal { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder.SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }
    }
}
