using System;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Dtos
{
    public abstract class BaseDto
    {

        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
