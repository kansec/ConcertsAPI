using AutoMapper;
using ConcertsAPI.Contracts;
using ConcertsAPI.Data;
using ConcertsAPI.Models.Artists;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConcertsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistsRepository _artistsRepository;
        private readonly IMapper _mapper;

        public ArtistsController(IMapper mapper,IArtistsRepository artistsRepository)
        {
            _mapper = mapper;
            _artistsRepository = artistsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
        {
            if (await _artistsRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var result = await _artistsRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtist(int id)
        {
            var result = await _artistsRepository.GetAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<Concert>> PostConcert(CreateArtistDto createArtistDto)
        {
            var artist = _mapper.Map<Artist>(createArtistDto);

            await _artistsRepository.AddAsync(artist);

            return CreatedAtAction("GetArtist", new { id = artist.Id }, artist);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConcert(int id, UpdateArtistDto updateArtistDto)
        {
            if (id != updateArtistDto.Id)
            {
                return BadRequest();
            }

            var artist = await _artistsRepository.GetAsync(id);

            if (artist == null)
            {
                return NotFound();
            }

            _mapper.Map(updateArtistDto, artist);

            try
            {
                await _artistsRepository.UpdateAsync(artist);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _artistsRepository.Exist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }



            }

            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConcert(int id)
        {
            if (!await _artistsRepository.Exist(id))
            {
                return NotFound();
            }

            await _artistsRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> ConcertExist(int id)
        {
            return await _artistsRepository.Exist(id);

        }


    }
}
