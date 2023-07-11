using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class MediaService : IMediaService
    {
        protected readonly IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public Task<Media> AddAsync(Media entity)
        {
            throw new NotImplementedException();
        }

        public Task<Media> DeleteAsync(Media entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Media> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Media> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Media>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Media> UpdateAsync(Media entity)
        {
            throw new NotImplementedException();
        }
    }
}
