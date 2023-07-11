using Imi.Project.Api.Core.Enums;
using System;

namespace Imi.Project.Api.Core.Entities
{
    public class Animal : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Guid BreedId { get; set; }
        public Breed Breed { get; set; }

        public string Description { get; set; }

        public Guid LocationId { get; set; }

        public Location Location { get; set; }

        public Guid MediaId { get; set; }

        public Media Media { get; set; }

        public bool IsFed { get; set; } = false;
        public bool IsWalked { get; set; } = false;

    }
}
