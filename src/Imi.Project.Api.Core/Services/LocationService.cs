using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class LocationService : ILocationService
    {
        protected readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public Task<Location> AddAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task<Location> DeleteAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Location> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Location> UpdateAsync(Location entity)
        {
            throw new NotImplementedException();
        }
    }
}
