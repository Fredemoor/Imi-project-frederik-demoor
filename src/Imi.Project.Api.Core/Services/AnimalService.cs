using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Api.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public Task<Animal> AddAsync(Animal entity)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> DeleteAsync(Animal entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Animal> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Animal>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Animal>> SearchAsync(string search)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> UpdateAsync(Animal entity)
        {
            throw new NotImplementedException();
        }
    }

}
