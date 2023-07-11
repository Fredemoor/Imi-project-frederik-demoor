using Imi.Project.Api.Dtos.Breeds;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiBreedLocationService : IBreedService
    {
        private string baseUri = Constants.BaseUrl;
        protected IAppHttpClient httpClient;
        public ApiBreedLocationService(IAppHttpClient client)
        {
            httpClient = client;
        }
        public Task<Breed> AddAsync(Breed entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Breed>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Breed>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Breed>> GetAllAsync()
        {
            var apiBreeds = await httpClient.GetApiResult<List<BreedDto>>($"{baseUri}/api/breeds");

            var breeds = new List<Breed>();

            breeds.AddRange(apiBreeds.Select(b => new Breed
            {
                Id = b.Id,
                BreedName = b.Breed,
            }));

            return breeds;
        }

        public Task<Breed> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Breed> UpdateAsync(Breed entity)
        {
            throw new NotImplementedException();
        }
    }
}
