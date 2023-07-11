using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Pin.Models
{
    public class Breed
    {
        public Guid Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
}
