using System.Collections.Generic;

namespace Imi.Project.Mobile.Domain.Models
{
    public class Location : BaseModel
    {
        public string Name { get; set; }
        public bool IsClean { get; set; }
        public bool IsFull { get; set; }
        public int Capacity { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
