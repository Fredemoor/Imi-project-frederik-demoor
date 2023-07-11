namespace Imi.Project.Pin.Services
{
    //public class MockBreedService : ICrudService<Breed>
    //{

    //    private static List<Breed> breeds = new()
    //    {
    //        new Breed
    //        {
    //            Id = 1,
    //            Name = "Podenco"
    //        },
    //        new Breed
    //        {
    //            Id = 2,
    //            Name = "Poedel"
    //        },
    //        new Breed
    //        {
    //            Id=3,
    //            Name="Stafford"
    //        },
    //        new Breed
    //        {
    //            Id =4,
    //            Name = "Labradoodle"
    //        },
    //        new Breed
    //        {
    //            Id = 5,
    //            Name = "Golden retriever"
    //        }
    //    };
    //    public Task Create(Breed item)
    //    {
    //        item.Id = breeds.Count() > 0 ? breeds.Max(x => x.Id) +1 : 1;
    //        breeds.Add(item);

    //        return Task.CompletedTask;
    //    }
    //    public Task Delete(int id)
    //    {
    //        var breed = breeds.FirstOrDefault(x => x.Id == id);
    //        if (breed == null) throw new ArgumentException($"could not find breed id:{id}");
    //        breeds.Remove(breed);
    //        return Task.CompletedTask;
    //    }


    //    public Task<Breed> Get(int id)
    //    {
    //        return Task
    //            .FromResult(breeds.FirstOrDefault(x => x.Id == id));
    //    }

    //    public Task<IQueryable<Breed>> GetAll()
    //    {
    //        return Task.FromResult(breeds.Select(b => new Breed()
    //        {
    //            Id = b.Id,
    //            Name = b.Name
    //        }).AsQueryable()
    //      );
    //    }


    //    public Task Update(Breed item)
    //    {
    //        var breed = breeds.FirstOrDefault(b => b.Id == item.Id);
    //        if (breed==null) throw new ArgumentException($"breed {breed} could not be found...");
    //        breed.Name = item.Name;

    //        return Task.CompletedTask;
    //    }
    //}
}
