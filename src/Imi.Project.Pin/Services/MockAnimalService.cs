namespace Imi.Project.Pin.Services
{
    //public class MockAnimalService : ICrudService<Animal>
    //{

    //    private static List<Animal> animals = new List<Animal>
    //    {
    //        new Animal
    //        {
    //            Id = 1,
    //            BirthDay = DateTime.UtcNow,
    //            Name = "Chappie",
    //            Description = "zeer lieve hond goed voor gezin met kinderen",
    //            Gender = Gender.Male,
    //            ImageUrl = "image0.png",
    //            LocationId = 1,
    //            BreedId = 1,
    //        },
    //        new Animal
    //        {
    //            Id = 2,
    //            BirthDay = DateTime.UtcNow,
    //            Name = "Geurbels",
    //            Description = "zeer luide hond",
    //            Gender = Gender.Male,
    //            ImageUrl = "image1.png",
    //            LocationId = 2,
    //            BreedId = 3,
    //        },
    //        new Animal {
    //            Id = 3,
    //            BirthDay = DateTime.UtcNow,
    //            Name = "Ozzy",
    //            Description = "zeer Leuk karakter hond",
    //            Gender = Gender.Female,
    //            ImageUrl = "image2.png",
    //            LocationId = 3,
    //            BreedId = 4,
    //        },
    //        new Animal {
    //            Id =4,
    //            BirthDay = DateTime.UtcNow,
    //            Name = "Schnoedel",
    //            Description = "Grappige energieke hond",
    //            Gender = Gender.Female,
    //            ImageUrl = "image3.png",
    //            LocationId = 4,
    //            BreedId = 3,
    //        },
    //         new Animal {
    //            Id = 5,
    //            BirthDay = DateTime.UtcNow,
    //            Name = "Sroedel",
    //            Description = "Creatieve Gekke hond",
    //            Gender = Gender.Female,
    //            ImageUrl = "image3.png",
    //            LocationId = 5,
    //            BreedId = 2
    //        }
    //    };

    //    public Task Create(Animal item)
    //    {
    //        item.Id = animals.Count() > 0 ? animals.Max(x => x.Id) + 1 : 1;
    //        animals.Add(item);
    //        return Task.CompletedTask;

    //    }

    //    public Task Delete(int id)
    //    {
    //        var animal = animals.SingleOrDefault(x => x.Id == id);
    //        if (animal == null) throw new ArgumentException("Dog was not found!");
    //        animals.Remove(animal);
    //        return Task.CompletedTask;
    //    }

    //    public Task<Animal> Get(int id)
    //    {
    //        return Task
    //            .FromResult(animals.SingleOrDefault(x => x.Id == id));
    //    }

    //    public Task<IQueryable<Animal>> GetAll()
    //    {
    //        return Task.FromResult(animals.Select(a => new Animal()
    //        {
    //            Id = a.Id,
    //            LocationId = a.LocationId,
    //            BreedId= a.BreedId,
    //            Name = a.Name,
    //            BreedName = a.BreedName,
    //            LocationName = a.LocationName,
    //            BirthDay= a.BirthDay,
    //            Gender = a.Gender,
    //            Description = a.Description,
    //            ImageUrl = a.ImageUrl,
    //        }).AsQueryable()
    //      );
    //    }

    //    public Task Update(Animal item)
    //    {
    //        var animal = animals.SingleOrDefault(x => x.Id == item.Id);
    //        if (animal == null) throw new ArgumentException("Dog was not found...");
    //        animal.BirthDay = item.BirthDay;
    //        animal.Gender = item.Gender;
    //        animal.Description = item.Description;
    //        animal.ImageUrl = item.ImageUrl;
    //        animal.Name = item.Name;
    //        animal.LocationName = item.LocationName;
    //        animal.BreedName = item.BreedName;
    //        animal.LocationId = item.LocationId;
    //        animal.BreedId = item.BreedId;

    //        return Task.CompletedTask;
    //    }
    // }
}
