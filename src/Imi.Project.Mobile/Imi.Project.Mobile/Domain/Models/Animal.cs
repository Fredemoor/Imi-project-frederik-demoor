using Imi.Project.Mobile.Domain.Enums;
using System;

namespace Imi.Project.Mobile.Domain.Models
{
    public class Animal : BaseModel
    {
        public Guid BreedId { get; set; }
        public Guid LocationId { get; set; }
        public Guid MediaId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public string Breed { get; set; }
        public string Media { get; set; }
        public string Location { get; set; }
        public bool IsFed { get; set; }
        public bool IsWalked { get; set; }

    }
}
