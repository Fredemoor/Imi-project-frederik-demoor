using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Api.Dtos.Animals;
using Imi.Project.Api.Dtos.Breeds;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{

    [Route("api/Breeds")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
        protected readonly IBreedRepository _breedRepository;
        protected readonly IAnimalRepository _animalRepository;


        public BreedsController(IBreedRepository breedRepository, IAnimalRepository animalRepository)
        {
            _breedRepository = breedRepository;
            _animalRepository = animalRepository;
        }

        [HttpGet]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetAll()
        {
            var breeds = await _breedRepository.ListAllAsync();

            var breedsDto = breeds.Select(b => new BreedResponseDto
            {
                Id = b.Id,
                Breed = b.AnimalBreed
            });

            return Ok(breedsDto);
        }

        [HttpGet("{id}")]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var breed = await _breedRepository.GetBreedById(id);

            if (breed == null)
            {
                return NotFound($"No breed was found under id {id}");
            }

            var breedDto = new BreedResponseDto
            {
                Breed = breed.AnimalBreed
            };

            return Ok(breedDto);
        }


        [HttpGet("{id}/animals")]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetAnimalByBreedId(Guid id)
        {
            var animals = await _animalRepository.GetAnimalByBreedId(id);
            if (animals.Count() == 0)
            {
                return NotFound($"Breed {id} not found");
            }
            var animalsDto = animals.Select(a => new AnimalResponseDto
            {
                Id = a.Id,
                Name = a.Name,
                BirthDate = a.BirthDate,
                Gender = a.Gender,
                IsFed = a.IsFed,
                IsWalked = a.IsWalked,
                Breed = a.Breed.AnimalBreed,
                Location = a.Location.Name,
                Media = a.Media.ImageUrl,
                Description = a.Description,
            });
            return Ok(animalsDto);
        }

        [HttpPut]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> Update(BreedRequestDto breedDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var breed = await _breedRepository.GetBreedById(breedDto.Id);

            if (breed == null)
            {
                return NotFound($"breed {breedDto.Breed} with ID {breedDto.Id} not found");
            }

            breed.AnimalBreed = breedDto.Breed;

            await _breedRepository.UpdateAsync(breed);

            return Ok(breed);

        }

        [HttpDelete("(id)")]
        //[Authorize(Policy = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var breed = await _breedRepository.GetBreedById(id);

            if (breed == null)
            {
                return NotFound($"The chosen breed with ID {id} has not been found");
            }

            await _breedRepository.DeleteAsync(breed);

            return Ok();
        }

        [HttpPost]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> Add(BreedRequestDto breedDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var breed = new Breed
            {
                AnimalBreed = breedDto.Breed
            };

            await _breedRepository.AddAsync(breed);

            return Ok();
        }
    }
}



