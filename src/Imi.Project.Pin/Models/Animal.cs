using Imi.Project.Pin.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Pin.Models
{
    public class Animal
    {

        public Guid Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }

        public Gender Gender { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int BreedId { get; set; }
        public string BreedName { get; set; }
    }
}
