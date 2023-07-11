using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Core.Entities
{
    public class Breed : BaseEntity
    {
        public string AnimalBreed { get; set; }

        [JsonIgnore]
        public ICollection<Animal> Animals { get; set; }
    }
}
