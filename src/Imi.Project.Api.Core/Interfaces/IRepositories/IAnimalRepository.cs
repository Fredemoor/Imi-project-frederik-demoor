using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.IRepositories
{
    public interface IAnimalRepository : IBaseRepository<Animal>
    {
        new Task<Animal> GetByIdAsync(Guid id);
        Task<IEnumerable<Animal>> GetAnimalByBreedId(Guid id);
        Task<IEnumerable<Animal>> SearchAsync(string search);
    }
}
