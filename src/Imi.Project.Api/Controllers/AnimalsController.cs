using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Api.Core.Repositories.Interfaces;
using Imi.Project.Api.Dtos.Animals;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/Animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        protected readonly IAnimalRepository _animalRepository;
        protected readonly ILocationRepository _locationRepository;
        protected readonly IBreedRepository _breedRepository;
        protected readonly IMediaRepository _mediaRepository;

        public AnimalsController(IAnimalRepository animalRepository, ILocationRepository locationRepository, IBreedRepository breedRepository, IMediaRepository mediaRepository)
        {
            _animalRepository = animalRepository;
            _locationRepository = locationRepository;
            _breedRepository = breedRepository;
            _mediaRepository = mediaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var animals = await _animalRepository
                                .ListAllAsync();
            var animalsDto = animals.Select(a => new AnimalResponseDto
            {
                Id = a.Id,
                Name = a.Name,
                BirthDate = a.BirthDate,
                Gender = a.Gender,
                IsFed = a.IsFed,
                IsWalked = a.IsWalked,
                Breed = a.Breed.AnimalBreed,
                BreedId = a.BreedId,
                Location = a.Location.Name,
                MediaId = a.MediaId,
                Media = a.Media.ImageUrl,
                Description = a.Description,
            });

            return Ok(animalsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var animals = await _animalRepository.GetByIdAsync(id);

            if (animals == null)
            {
                return NotFound($"No dog was found under id {id}");
            }

            var animalsDto = new AnimalResponseDto
            {
                Id = animals.Id,
                Name = animals.Name,
                BirthDate = animals.BirthDate,
                Gender = animals.Gender,
                IsFed = animals.IsFed,
                IsWalked = animals.IsWalked,
                BreedId = animals.BreedId,
                Breed = animals.Breed.AnimalBreed,
                LocationId = animals.LocationId,
                Location = animals.Location.Name,
                MediaId = animals.MediaId,
                Media = animals.Media.ImageUrl,
                Description = animals.Description,

            };

            return Ok(animalsDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(AnimalRequestDto animalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var animalEntity = await _animalRepository.GetByIdAsync
                (animalDto.Id);

            if (animalEntity == null)
            {
                return NotFound($"No animal with the ID of {animalDto.Id} has been found");
            }
            animalEntity.Name = animalDto.Name;
            animalEntity.Description = animalDto.Description;
            animalEntity.Gender = animalDto.Gender;
            animalEntity.IsFed = animalDto.IsFed;
            animalEntity.IsWalked = animalDto.IsWalked;
            animalEntity.UpdatedDate = animalDto.UpdateDate;
            animalEntity.Location = await _locationRepository.GetByIdAsync(animalDto.LocationId);
            animalEntity.Breed = await _breedRepository.GetBreedById(animalDto.BreedId);
            animalEntity.Media = await _mediaRepository.GetByIdAsync(animalDto.MediaId);

            await _animalRepository.UpdateAsync(animalEntity);

            return Ok(animalEntity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var animalEntity = await _animalRepository.GetByIdAsync(id);

            if (animalEntity == null)
            {
                return NotFound($"The chosen animal with ID {id} has not been found");
            }
            await _animalRepository.DeleteAsync(animalEntity);

            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AnimalRequestDto animalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var animalEntity = new Animal
            {
                Name = animalDto.Name,
                Description = animalDto.Description,
                Gender = animalDto.Gender,
                BirthDate = animalDto.BirthDate,

                Location = await _locationRepository.GetByIdAsync(animalDto.LocationId),
                Breed = await _breedRepository.GetByIdAsync(animalDto.BreedId),
                Media = await _mediaRepository.GetByIdAsync(animalDto.MediaId)
            };
            await _animalRepository.AddAsync(animalEntity);

            return Ok();
        }
    }
}
