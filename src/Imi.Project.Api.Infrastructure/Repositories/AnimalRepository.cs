
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class AnimalRepository : BaseRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IQueryable<Animal> GetAll()
        {
            return _dbContext.Animals.Include(a => a.Breed)
                .Include(a => a.Location)
                .Include(a => a.Media);
        }

        public override async Task<IEnumerable<Animal>> ListAllAsync()
        {
            var animals = await GetAll().ToListAsync();
            return animals;
        }
        public override async Task<Animal> GetByIdAsync(Guid id)
        {
            var animal = await GetAll().SingleOrDefaultAsync(a => a.Id.Equals(id));
            return animal;
        }

        public async Task<IEnumerable<Animal>> GetAnimalByLocation(Location location)
        {
            return await GetAll()
                .Where(a => a.Location
                    .Equals(location))
                .ToListAsync();
        }

        public async Task<IEnumerable<Animal>> GetAnimalByBreedId(Guid id)
        {
            return await GetAll()
                .Where(a => a.BreedId.Equals(id))
                .ToListAsync();
        }

        public async Task<IEnumerable<Animal>> SearchAsync(string search)
        {
            var animals = await GetAll()
                .Where(a => a.Name.Contains(search.Trim().ToUpper()) || a.Breed.AnimalBreed.Contains(search.Trim().ToUpper()))
                .ToListAsync();

            return animals;
        }

    }
}
