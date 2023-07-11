using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Breeds
{
    public class BreedRequestDto : BaseDto
    {
        [JsonPropertyName("breed")]
        public string Breed { get; set; }


    }
}
