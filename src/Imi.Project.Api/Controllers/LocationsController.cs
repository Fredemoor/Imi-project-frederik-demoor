using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Api.Dtos.Locations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{

    [Route("api/Locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        protected readonly ILocationRepository _locationRepository;
        protected readonly IAnimalRepository _animalRepository;

        public LocationsController(ILocationRepository locationRepository, IAnimalRepository animalRepository)
        {
            _locationRepository = locationRepository;
            _animalRepository = animalRepository;
        }

        [HttpGet]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetAll()
        {
            var locations = await _locationRepository.ListAllAsync();


            var LocationDto = locations.Select(l => new LocationResponseDto
            {
                Id = l.Id,
                Name = l.Name,
                Capacity = l.Capacity,
                IsFull = l.IsFull,
                IsCleaned = l.IsCleaned,
                Animals = l.Animals,
            });

            return Ok(LocationDto);
        }

        [HttpGet("{id}")]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var location = await _locationRepository.GetByIdAsync(id);

            if (location == null)
            {
                return NotFound($"No location was found under id {id}");
            }

            var locationDto = new LocationResponseDto
            {
                Id = location.Id,
                Name = location.Name
            };

            return Ok(locationDto);
        }

        [HttpPut]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> Update(LocationRequestDto locationDto)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var location = await _locationRepository.GetByIdAsync(locationDto.Id);

            if (location == null)
            {
                return NotFound($"Location {locationDto.Name} with ID {locationDto.Id} not found");
            }

            location.Name = locationDto.Name;


            await _locationRepository.UpdateAsync(location);

            return Ok(location);

        }

        [HttpDelete("(id)")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var location = await _locationRepository.GetByIdAsync(id);

            if (location == null)
            {
                return NotFound($"The chosen location with ID {id} has not been found");
            }

            await _locationRepository.DeleteAsync(location);

            return Ok();
        }

        [HttpPost]
        [Authorize(Policy = "Admin")]
        [Authorize(Policy = "User")]
        public async Task<IActionResult> Add(LocationRequestDto locationDto)
        {
            var location = new Location
            {
                Name = locationDto.Name
            };

            await _locationRepository.AddAsync(location);

            return Ok();
        }
    }
}

