using Imi.Project.Pin.Models;
using Imi.Project.Pin.Services.Api.Dtos;

namespace Imi.Project.Pin.Services.Api
{
    public class LocationsApiService : ICrudService<Location>
    {
        private const string BaseUrl = Constants.BaseUrl;
        private readonly HttpClient _httpClient;


        public LocationsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<Location> Get(Guid id)
        {
            var dto = await _httpClient.GetFromJsonAsync<LocationRequestDto>($"{BaseUrl}/Api/Locations/{id}");
            return new Location
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }

        public async Task<IQueryable<Location>> GetAll()
        {
            var dtos = await _httpClient.GetFromJsonAsync<LocationRequestDto[]>($"{BaseUrl}/Api/Locations");
            return dtos.Select(dto => new Location
            {
                Id = dto!.Id,
                Name = dto.Name
            }).AsQueryable();
        }

        public Task Create(Location item)
        {
            throw new NotImplementedException();
        }

        public Task Update(Location item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
