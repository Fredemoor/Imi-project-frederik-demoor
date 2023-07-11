using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Breeds
{
    public class BreedDto : BaseDto
    {
        [JsonPropertyName("breed")]
        public string Breed { get; set; }
    }
}
