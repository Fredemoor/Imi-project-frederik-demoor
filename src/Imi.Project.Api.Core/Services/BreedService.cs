using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class BreedService : IBreedService
    {
        protected readonly IBreedRepository _breedRepository;

        public BreedService(IBreedRepository breedRepository)
        {
            _breedRepository = breedRepository;
        }

        public Task<Breed> AddAsync(Breed entity)
        {
            throw new NotImplementedException();
        }

        public Task<Breed> DeleteAsync(Breed entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Breed> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Breed> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Breed>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Breed> UpdateAsync(Breed entity)
        {
            throw new NotImplementedException();
        }
    }
}
