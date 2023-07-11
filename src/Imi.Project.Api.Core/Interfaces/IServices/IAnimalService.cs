using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.IServices
{
    public interface IAnimalService : IBaseService<Animal>
    {
        Task<IEnumerable<Animal>> SearchAsync(string search);
    }
}
