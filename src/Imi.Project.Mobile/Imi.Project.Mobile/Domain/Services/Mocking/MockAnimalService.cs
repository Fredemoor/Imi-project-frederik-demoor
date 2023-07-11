namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockAnimalService
    {

        //private static List<Animal> animalsList = new List<Animal>
        //{
        //    new Animal
        //    {
        //        Id = Guid.Parse("11111111-0000-0000-0000-000000000001"),
        //        Birthdate = new DateTime(2016,08,8),
        //        Name = "Chappie",
        //        Description = "zeer lieve hond goed voor gezin met kinderen",
        //        Gender = Enums.Gender.Male,
        //        ImageUrl = "image0.png",
        //        Breed = "Podenco",
        //        IsFed = false,
        //        IsWalked = false,
        //    },
        //    new Animal
        //    {
        //        Id = Guid.Parse("22222222-0000-0000-0000-000000000002"),
        //        Birthdate = new DateTime(2019,02,12),
        //        Name = "Sjonnie",
        //        Description = "zeer luide hond",
        //        Gender = Enums.Gender.Male,
        //        ImageUrl = "image1.png",
        //        Breed = "Pitbull",
        //        IsFed = true,
        //        IsWalked = false
        //    },
        //    new Animal {
        //        Id = Guid.Parse("33333333-0000-0000-0000-000000000002"),
        //        Birthdate = new DateTime(2019,02,12),
        //        Name = "Ozzy",
        //        Description = "zeer Leuk karakter hond",
        //        Gender = Enums.Gender.Female,
        //        ImageUrl = "image2.png",
        //        Breed = "Australian CattleDog",
        //        IsFed = true,
        //        IsWalked = true
        //    },
        //    new Animal {
        //        Id = Guid.Parse("44444444-0000-0000-0000-000000000002"),
        //        Birthdate = new DateTime(2015,08,1),
        //        Name = "Schnoedel",
        //        Description = "Grappige energieke hond",
        //        Gender = Enums.Gender.Female,
        //        ImageUrl = "image3.png",
        //        Breed = "Labradoodle",
        //        IsFed = true,
        //        IsWalked = true
        //    },
        //      new Animal {
        //        Id = Guid.Parse("44444444-0000-0000-0000-000000000002"),
        //        Birthdate = new DateTime(2012, 2, 2),
        //        Name = "sproedel",
        //        Description = "Grappige energieke hond",
        //        Gender = Enums.Gender.Female,
        //        ImageUrl = "image3.png",
        //        Breed = "check",
        //        IsFed = true,
        //        IsWalked = true
        //    }
        //};


        //public async Task<Animal> AddAsync(Animal entity)
        //{
        //    animalsList.Add(entity);
        //    return await Task.FromResult(entity);
        //}

        //public  async Task<IList<Animal>> DeleteAsync(Guid id)
        //{
        //    var animalsList = await GetAllAsync();
        //    var entityToRemove = animalsList.FirstOrDefault(e => e.Id == id);
        //    animalsList.Remove(entityToRemove);

        //    return animalsList;
        //}

        //public Task<IList<Animal>> DeleteAsync(Animal entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IQueryable<Animal>> GetAll()
        //{
        //    var animals = animalsList.AsQueryable();
        //    return await Task.FromResult(animals);
        //}

        //public async Task<IList<Animal>> GetAllAsync()
        //{
        //    var animals = await GetAll();
        //    return animals.ToList();
        //}

        //public async Task<Animal> GetByIdAsync(Guid id)
        //{
        //    var animals = animalsList.FirstOrDefault(a => a.Id.Equals(id));
        //    return await Task.FromResult(animals);
        //}

        //public Task<IEnumerable<Animal>> Search(string search)
        //{
        //    //var animals = await animalsList
        //    //    .Where(a => a.Name.Contains(search.Trim().ToUpper())|| a.Breed.Contains(search.Trim().ToUpper().ToList()));
        //    //return await Task.FromResult(animals);
        //    throw new NotImplementedException();
        //}

        //public async Task<Animal> UpdateAsync(Animal entity)
        //{
        //    var oldEntity = animalsList.First(a => a.Id.Equals(entity.Id));
        //    animalsList.Remove(oldEntity);
        //    animalsList.Add(entity);
        //    return await Task.FromResult(entity);
        //}


    }
}
