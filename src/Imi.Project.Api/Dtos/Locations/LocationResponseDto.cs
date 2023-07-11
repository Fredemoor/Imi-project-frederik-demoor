using Imi.Project.Api.Core.Entities;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Locations
{
    public class LocationResponseDto : BaseDto
    {
        [JsonPropertyName("location")]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsFull { get; set; }
        public bool IsCleaned { get; set; }
        public ICollection<Animal> Animals { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
