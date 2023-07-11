using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<IEnumerable<Location>> ListAllAsync()
        {
            var locations = await GetAll().ToListAsync();
            return locations;
        }

        public async Task<Location> GetLocationById(Guid id)
        {
            var location = await GetByIdAsync(id);
            return location;
        }
    }
}
