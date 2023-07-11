using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsFull { get; set; } = false;
        public bool IsCleaned { get; set; } = false;
        public ICollection<Animal> Animals { get; set; }
    }
}
