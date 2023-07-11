using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Api.Dtos.Locations
{
    public class LocationRequestDto : BaseDto
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsFull { get; set; }
        public bool IsCleaned { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
