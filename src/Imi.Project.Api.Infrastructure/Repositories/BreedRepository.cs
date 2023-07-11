using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BreedRepository : BaseRepository<Breed>, IBreedRepository
    {
        public BreedRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<IEnumerable<Breed>> ListAllAsync()
        {
            var breeds = await GetAll().ToListAsync();
            return breeds;
        }

        public async Task<Breed> GetBreedById(Guid id)
        {
            var breed = await GetByIdAsync(id);
            return breed;
        }
    }
}
