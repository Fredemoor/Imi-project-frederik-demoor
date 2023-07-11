using Imi.Project.Api.Core.Enums;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos.Animals
{
    public class AnimalResponseDto : BaseDto
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("BirthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("updateDate")]
        public DateTime UpdateDate { get; set; }

        [JsonPropertyName("gender")]
        public Gender Gender { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("isFed")]
        public bool IsFed { get; set; }

        [JsonPropertyName("isWalked")]
        public bool IsWalked { get; set; }

        [JsonPropertyName("BreedId")]
        public Guid BreedId { get; set; }
        [JsonPropertyName("breed")]
        public string Breed { get; set; }

        [JsonPropertyName("MediaId")]
        public Guid MediaId { get; set; }

        [JsonPropertyName("media")]
        public string Media { get; set; }

        [JsonPropertyName("LocationId")]
        public Guid LocationId { get; set; }

    }
}
