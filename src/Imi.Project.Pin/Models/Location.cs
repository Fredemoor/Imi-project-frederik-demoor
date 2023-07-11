using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Imi.Project.Pin.Models
{
    public class Location
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "De gekozen naam is te lang")]
        public string Name { get; set; }
    }
}
