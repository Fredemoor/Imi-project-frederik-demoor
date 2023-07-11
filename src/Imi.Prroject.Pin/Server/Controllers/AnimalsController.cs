using Imi.Project.Pin.Data.Enums;
using Imi.Prroject.Pin.Shared.Model;
using Imi.Prroject.Pin.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Prroject.Pin.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {

        private static List<Animal> animals = new List<Animal>
        {
            new Animal
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000001"),
                BirthDay = DateTime.UtcNow,
                Name = "Chappie",
                Description = "zeer lieve hond goed voor gezin met kinderen",
                Gender = Gender.Male,
                ImageUrl = "image0.png",
                Breed = Breed.Podenco,
            },
            new Animal
            {
                Id = Guid.Parse("22222222-0000-0000-0000-000000000002"),
                BirthDay = DateTime.UtcNow,
                Name = "Geurbels",
                Description = "zeer luide hond",
                Gender = Gender.Male,
                ImageUrl = "image1.png",
                Breed = Breed.RottKweiler,
            },
            new Animal {
                Id = Guid.Parse("33333333-0000-0000-0000-000000000002"),
                BirthDay = DateTime.UtcNow,
                Name = "Ozzy",
                Description = "zeer Leuk karakter hond",
                Gender = Gender.Female,
                ImageUrl = "image2.png",
                Breed = Breed.Pincher,

            },
            new Animal {
                Id = Guid.Parse("44444444-0000-0000-0000-000000000002"),
                BirthDay = DateTime.UtcNow,
                Name = "Schnoedel",
                Description = "Grappige energieke hond",
                Gender = Gender.Female,
                ImageUrl = "image3.png",
                Breed = Breed.PitBull
            },
             new Animal {
                Id = Guid.Parse("55555555-0000-0000-0000-000000000002"),
                BirthDay = DateTime.UtcNow,
                Name = "Sroedel",
                Description = "Creatieve Gekke hond",
                Gender = Gender.Female,
                ImageUrl = "image3.png",
                Breed = Breed.Labradoodel
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Animal>>> Get()
        {
            return await Task.FromResult(animals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetById(Guid id)
        {
            var animal = animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return NotFound($"Dog not found");
            }
            return Ok(animal);
        }

    }
}
