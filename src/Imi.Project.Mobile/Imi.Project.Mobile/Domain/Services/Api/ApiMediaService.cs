using Imi.Project.Api.Dtos.Animals;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiMediaService : IMediaService
    {
        private string baseUri = Constants.BaseUrl;
        protected IAppHttpClient httpClient;
        public ApiMediaService(IAppHttpClient client)
        {
            httpClient = client;
        }

        public Task<IEnumerable<Media>> Search(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Media>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Media>> GetAllAsync()
        {
            var apiMedias = await httpClient.GetApiResult<List<AnimalDto>>($"{baseUri}/api/medias");

            var medias = new List<Media>();

            medias.AddRange(apiMedias.Select(m => new Media
            {
                Id = m.Id,
                ImageUrl = m.Media
            }));

            return medias;
        }

        public async Task<Media> GetByIdAsync(Guid id)
        {
            var apiMediaById = await httpClient.GetApiResult<Media>($"{baseUri}/api/media/{id}");
            return apiMediaById;

        }

        public Task<Media> AddAsync(Media entity)
        {
            throw new NotImplementedException();
        }

        public Task<Media> UpdateAsync(Media entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Media>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}


