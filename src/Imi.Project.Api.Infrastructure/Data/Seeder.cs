using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace Imi.Project.Infrastructure.Data;

public class Seeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {

        Guid[] userId = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        Guid[] BreedId = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        Guid[] MediaId = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        Guid[] LocationId = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        Guid[] AnimalId = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        IPasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();


        //ADMIN

        var admin = new ApplicationUser
        {
            Id = userId[0].ToString(),
            UserName = "ImiAdmin",
            NormalizedUserName = "IMIADMIN",
            Email = "admin@imi.com",
            NormalizedEmail = "ADMIN@IMI.COM",
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            HasApprovedTermsAndConditions = true,
            Birthdate = new DateTime(2000, 10, 12),
            EmailConfirmed = true
        };

        admin.PasswordHash = passwordHasher.HashPassword(admin, "Test123?");

        modelBuilder.Entity<ApplicationUser>().HasData(admin);

        modelBuilder.Entity<IdentityUserClaim<string>>()
            .HasData(new IdentityUserClaim<string>
            {
                Id = 1,
                UserId = userId[0].ToString(),
                ClaimType = ClaimTypes.Role,
                ClaimValue = "admin"
            });

        //REFUSER

        var refuser = new ApplicationUser
        {
            Id = userId[1].ToString(),
            UserName = "ImiRefuser",
            NormalizedUserName = "IMIREFUSER",
            Email = "refuser@imi.com",
            NormalizedEmail = "REFUSER@IMI.COM",
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            HasApprovedTermsAndConditions = false,
            Birthdate = new DateTime(1920, 5, 1),
            EmailConfirmed = true
        };

        refuser.PasswordHash = passwordHasher.HashPassword(refuser, "Test123?");

        modelBuilder.Entity<ApplicationUser>().HasData(refuser);

        modelBuilder.Entity<IdentityUserClaim<string>>()
            .HasData(new IdentityUserClaim<string>
            {
                Id = 2,
                UserId = userId[1].ToString(),
                ClaimType = ClaimTypes.Role,
                ClaimValue = "user"
            });

        var user = new ApplicationUser
        {
            Id = userId[2].ToString(),
            UserName = "ImiUser",
            NormalizedUserName = "IMIUSER",
            Email = "user@imi.com",
            NormalizedEmail = "USER@IMI.COM",
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            HasApprovedTermsAndConditions = true,
            Birthdate = new DateTime(1920, 5, 1),
            EmailConfirmed = true
        };

        user.PasswordHash = passwordHasher.HashPassword(user, "Test123?");

        modelBuilder.Entity<ApplicationUser>().HasData(user);

        modelBuilder.Entity<IdentityUserClaim<string>>()
            .HasData(new IdentityUserClaim<string>
            {
                Id = 3,
                UserId = userId[2].ToString(),
                ClaimType = ClaimTypes.Role,
                ClaimValue = "user"
            });


        modelBuilder.Entity<Breed>().HasData(
            new Breed
            {
                Id = BreedId[0],
                AnimalBreed = "Podenco"
            },
            new Breed
            {
                Id = BreedId[1],
                AnimalBreed = "Pincher"
            },
            new Breed
            {
                Id = BreedId[2],
                AnimalBreed = "Labrador"
            },
            new Breed
            {
                Id = BreedId[3],
                AnimalBreed = "Malteser"
            },
            new Breed
            {
                Id = BreedId[4],
                AnimalBreed = "Stafford"
            },
            new Breed
            {
                Id = BreedId[5],
                AnimalBreed = "Australian Cattle dog"
            },
            new Breed
            {
                Id = BreedId[6],
                AnimalBreed = "Akita"
            },
            new Breed
            {
                Id = BreedId[7],
                AnimalBreed = "AKita inu"
            },
            new Breed
            {
                Id = BreedId[8],
                AnimalBreed = "Alaskan Malamute Dog"
            },
            new Breed
            {
                Id = BreedId[9],
                AnimalBreed = "American Cocker Spaniel"
            }
            );


        modelBuilder.Entity<Media>().HasData(
            new Media
            {
                Id = MediaId[0],
                ImageUrl = "Img/img0.png"
            },
            new Media
            {
                Id = MediaId[1],
                ImageUrl = "Img/img1.png"
            },
            new Media
            {
                Id = MediaId[2],
                ImageUrl = "Img/img2.png"
            },
            new Media
            {
                Id = MediaId[3],
                ImageUrl = "Img/img3.png"
            },
            new Media
            {
                Id = MediaId[4],
                ImageUrl = "Img/img4.png"
            },
            new Media
            {
                Id = MediaId[5],
                ImageUrl = "Img/img5.png"
            },
            new Media
            {
                Id = MediaId[6],
                ImageUrl = "Img/img6.png"
            },
            new Media
            {
                Id = MediaId[7],
                ImageUrl = "Img/img7.png"
            },
            new Media
            {
                Id = MediaId[8],
                ImageUrl = "Img/img8.png"
            },
            new Media
            {
                Id = MediaId[9],
                ImageUrl = "Img/img9.png"
            },
            new Media
            {
                Id = MediaId[10],
                ImageUrl = "Img/img10.png"
            },
               new Media
               {
                   Id = MediaId[11],
                   ImageUrl = "Img/img11.png"
               }
            );

        modelBuilder.Entity<Location>().HasData(
            new Location
            {
                Id = LocationId[0],
                Name = "Kennel 1",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[1],
                Name = "Kennel 2",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[2],
                Name = "Kennel 3",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[3],
                Name = "Kennel 4",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[4],
                Name = "Kennel 5",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            }, new Location
            {
                Id = LocationId[5],
                Name = "Kennel 6",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[6],
                Name = "Kennel 7",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
            new Location
            {
                Id = LocationId[7],
                Name = "Kennel 8",
                Capacity = 1,
                IsCleaned = false,
                IsFull = true
            },
             new Location
             {
                 Id = LocationId[8],
                 Name = "Kennel 9",
                 Capacity = 1,
                 IsCleaned = false,
                 IsFull = true
             },
              new Location
              {
                  Id = LocationId[9],
                  Name = "Kennel 10",
                  Capacity = 1,
                  IsCleaned = true,
                  IsFull = true
              },
              new Location
              {
                  Id = LocationId[10],
                  Name = "Kennel 11",
                  Capacity = 1,
                  IsCleaned = false,
                  IsFull = true
              },
                new Location
                {
                    Id = LocationId[11],
                    Name = "Kennel 10",
                    Capacity = 1,
                    IsCleaned = true,
                    IsFull = true
                }
            );

        modelBuilder.Entity<Animal>().HasData(

            new Animal
            {
                Id = AnimalId[0],
                Name = "Chappie",
                BirthDate = new DateTime(2018, 2, 6),
                Gender = Gender.Male,
                CreatedDate = DateTime.UtcNow,
                Description = "Zacht karaKter, redelijk schuw.",
                BreedId = BreedId[0],
                LocationId = LocationId[0],
                MediaId = MediaId[0]
            },
             new Animal
             {
                 Id = AnimalId[1],
                 Name = "Ozzy",
                 BirthDate = new DateTime(2018, 2, 6),
                 Gender = Gender.Female,
                 CreatedDate = DateTime.UtcNow,
                 Description = "Zeer energetisch karakter",
                 BreedId = BreedId[1],
                 LocationId = LocationId[1],
                 MediaId = MediaId[1]
             },
                 new Animal
                 {
                     Id = AnimalId[2],
                     Name = "Kiba",
                     BirthDate = new DateTime(2018, 2, 6),
                     Gender = Gender.Male,
                     CreatedDate = DateTime.UtcNow,
                     Description = "Niet voor beginnelingen, kan agressief zijn.",
                     BreedId = BreedId[2],
                     LocationId = LocationId[2],
                     MediaId = MediaId[2]
                 },
                     new Animal
                     {
                         Id = AnimalId[3],
                         Name = "Bobbie",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Male,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Speelse rakker, zeer energetisch.",
                         BreedId = BreedId[3],
                         LocationId = LocationId[3],
                         MediaId = MediaId[3]
                     },
                     new Animal
                     {
                         Id = AnimalId[4],
                         Name = "Weppie",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Male,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Niet voor beginnelingen, redelijk boosaardig.",
                         BreedId = BreedId[4],
                         LocationId = LocationId[4],
                         MediaId = MediaId[4]
                     },
                     new Animal
                     {
                         Id = AnimalId[5],
                         Name = "Marco",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Male,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Goede familie hond, fan van water polo.",
                         BreedId = BreedId[5],
                         LocationId = LocationId[5],
                         MediaId = MediaId[5]
                     },
                     new Animal
                     {
                         Id = AnimalId[6],
                         Name = "Polo",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Male,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Zacht karacter, redelijk schuw.",
                         BreedId = BreedId[6],
                         LocationId = LocationId[6],
                         MediaId = MediaId[6]
                     },
                     new Animal
                     {
                         Id = AnimalId[7],
                         Name = "Linda",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Female,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Linda gaat graag zwemmen.",
                         BreedId = BreedId[7],
                         LocationId = LocationId[7],
                         MediaId = MediaId[7]
                     },
                     new Animal
                     {
                         Id = AnimalId[8],
                         Name = "Cindy",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Female,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Zacht karacter, redelijk schuw.",
                         BreedId = BreedId[8],
                         LocationId = LocationId[8],
                         MediaId = MediaId[8]
                     },
                     new Animal
                     {
                         Id = AnimalId[9],
                         Name = "Sjonnie",
                         BirthDate = new DateTime(2018, 2, 6),
                         Gender = Gender.Male,
                         CreatedDate = DateTime.UtcNow,
                         Description = "Zacht karacter, redelijk schuw.",
                         BreedId = BreedId[9],
                         LocationId = LocationId[9],
                         MediaId = MediaId[9]
                     }

            );
    }
}

