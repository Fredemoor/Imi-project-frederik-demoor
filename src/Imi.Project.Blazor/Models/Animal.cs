
using Imi.Project.Blazor.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.Entities
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public string ImageUrl { get; set; }
        public string Breed { get; set; }
    }
}
