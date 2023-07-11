using Imi.Project.Api.Dtos.Locations;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiLocationService : ILocationService
    {

        public string baseUri = Constants.BaseUrl;
        protected IAppHttpClient httpClient;



        public ApiLocationService(IAppHttpClient client)
        {
            httpClient = client;
        }

        public Task<Location> AddAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Location>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Location>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            var apiLocations = await httpClient.GetApiResult<List<LocationDto>>($"{baseUri}/api/locations");

            var locations = new List<Location>();
            locations.AddRange(apiLocations.Select(l => new Location
            {
                Id = l.Id,
                Name = l.Location,
                IsClean = l.IsClean
            }));
            return locations.OrderBy(l => l.Name);
        }

        public async Task<Location> GetByIdAsync(Guid id)
        {
            var apiLocationById = await httpClient.GetApiResult<LocationDto>($"{baseUri}/api/locations/{id}");

            var locationById = new Location();
            locationById.Id = apiLocationById.Id;
            locationById.Name = apiLocationById.Location;
            locationById.Capacity = apiLocationById.Capacity;
            locationById.Animals = apiLocationById.Animals;
            locationById.IsFull = apiLocationById.IsFull;
            locationById.IsClean = apiLocationById.IsClean;

            return locationById;
        }

        public Task<Location> UpdateAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        Task<IList<Location>> IBaseService<Location>.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
