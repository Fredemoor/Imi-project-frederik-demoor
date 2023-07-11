using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Breeds
{
    public class BreedResponseDto : BaseDto
    {

        [JsonPropertyName("breed")]
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{Breed}";
        }
    }
}
