using Imi.Project.Mobile.Domain.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Locations
{
    public class LocationDto : BaseDto
    {


        public string Location { get; set; }
        [JsonPropertyName("IsCLean")]
        public bool IsClean { get; set; }
        [JsonPropertyName("Capacity")]
        public int Capacity { get; set; }
        [JsonPropertyName("IsFull")]
        public bool IsFull { get; set; }
        [JsonPropertyName("IsCLeaned")]
        public bool IsCleaned { get; set; }
        [JsonPropertyName("animals")]
        public ICollection<Animal> Animals { get; set; }
    }
}
