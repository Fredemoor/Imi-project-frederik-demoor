using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.IRepositories;
using Imi.Project.Api.Dtos.Medias;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/Medias")]
    [ApiController]
    public class MediasController : ControllerBase
    {

        protected readonly IMediaRepository _mediaRepository;

        public MediasController(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        [HttpGet]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetAll()
        {
            var medias = await _mediaRepository.ListAllAsync();

            var mediaDto = medias.Select(m => new MediaResponseDto
            {
                Id = m.Id,
                ImageUrl = m.ImageUrl
            });

            return Ok(mediaDto);
        }

        [HttpGet("{id}/medias")]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetMediaByAnimalMediaId(Guid id)
        {
            var media = await _mediaRepository.GetByIdAsync(id);
            if (media == null)
            {
                return NotFound($"Media id {id} not found");
            }
            var mediasDto = new MediaResponseDto
            {
                Id = media.Id,
                ImageUrl = media.ImageUrl
            };


            return Ok(mediasDto);
        }

        [HttpGet("{id}")]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var media = await _mediaRepository.GetByIdAsync(id);

            if (media == null)
            {
                return NotFound($"No picture was found under id {id}");
            }

            var mediaDto = new MediaResponseDto
            {
                Id = media.Id,
                ImageUrl = media.ImageUrl
            };

            return Ok(mediaDto);
        }

        [HttpPut]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> Update(MediaRequestDto mediaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var media = await _mediaRepository.GetByIdAsync(mediaDto.Id);

            if (media == null)
            {
                return NotFound($"picture {mediaDto.ImageUrl} with ID {mediaDto.Id} not found");
            }

            media.ImageUrl = mediaDto.ImageUrl;
            media.UpdatedDate = DateTime.UtcNow;

            await _mediaRepository.UpdateAsync(media);

            return Ok(media);

        }

        [HttpDelete("(id)")]
        //[Authorize(Policy = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var media = await _mediaRepository.GetByIdAsync(id);

            if (media == null)
            {
                return NotFound($"The chosen picture with ID {id} has not been found");
            }

            await _mediaRepository.DeleteAsync(media);

            return Ok();
        }

        [HttpPost]
        //[Authorize(Policy = "Admin")]
        //[Authorize(Policy = "User")]
        public async Task<IActionResult> Add(MediaRequestDto mediaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var media = new Media
            {
                ImageUrl = mediaDto.ImageUrl
            };

            await _mediaRepository.AddAsync(media);

            return Ok();
        }
    }
}

