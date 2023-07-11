using Imi.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Interfaces
{
    public interface IAnimalService : IBaseService<Animal>
    {
        Task<IEnumerable<Animal>> Search(string search);

    }
}
