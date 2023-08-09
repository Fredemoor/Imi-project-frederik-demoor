using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    //public DbSet<User> Users { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Primary keys
        modelBuilder
         .Entity<Animal>()
         .HasKey(a => a.Id);

        modelBuilder
            .Entity<Breed>()
            .HasKey(b => b.Id);

        modelBuilder
            .Entity<Location>()
            .HasKey(l => l.Id);

        modelBuilder
           .Entity<Location>()
           .HasMany(l => l.Animals)
           .WithOne(a => a.Location);

        //DB RELATIONS

        modelBuilder
            .Entity<Animal>()
             .Property(a => a.Name)
             .HasMaxLength(20)
             .IsRequired();

        modelBuilder
            .Entity<Animal>()
             .Property(a => a.BirthDate)
             .HasMaxLength(20)
             .IsRequired();

        modelBuilder
            .Entity<Animal>()
             .Property(a => a.Gender)
             .IsRequired();

        modelBuilder
            .Entity<Location>()
             .Property(l => l.Name)
             .HasMaxLength(20)
             .IsRequired();

        //Seed this to the DB
        Seeder.SeedData(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

}
