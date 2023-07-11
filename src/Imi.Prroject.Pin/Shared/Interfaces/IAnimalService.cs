using Imi.Prroject.Pin.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Prroject.Pin.Shared.Interfaces
{
    public interface IAnimalService
    {
        List<Animal> Animals { get; set; }
        Task GetAnimals();
        Task<Animal> GetAnimalById(Guid id);

    }
}
