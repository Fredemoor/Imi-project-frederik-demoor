using Imi.Project.Api.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Repositories.Interfaces
{
    public interface IBreedRepository : IBaseRepository<Breed>
    {
        Task<Breed> GetBreedById(Guid id);
    }
}
