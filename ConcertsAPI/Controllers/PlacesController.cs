using AutoMapper;
using ConcertsAPI.Contracts;
using ConcertsAPI.Data;
using ConcertsAPI.Models.Places;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConcertsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlacesRepository _placesRepository;
        private readonly IMapper _mapper;

        public PlacesController(IMapper mapper,IPlacesRepository placesRepository)
        {
            _mapper = mapper;
            _placesRepository = placesRepository;

        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Place>>> GetPlaces()
        {
            if (await _placesRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var result = await _placesRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlace(int id)
        {
            var result = await _placesRepository.GetAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<Place>> PostPlace(CreatePlaceDto createPlaceDto)
        {
            var place = _mapper.Map<Place>(createPlaceDto);

            await _placesRepository.AddAsync(place);

            return CreatedAtAction("GetPlace", new { id = place.Id }, place);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlace(int id, UpdatePlaceDto updatePlaceDto)
        {
            if (id != updatePlaceDto.Id)
            {
                return BadRequest();
            }

            var place = await _placesRepository.GetAsync(id);

            if (place == null)
            {
                return NotFound();
            }

            _mapper.Map(updatePlaceDto, place);

            try
            {
                await _placesRepository.UpdateAsync(place);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _placesRepository.Exist(id))
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
        public async Task<IActionResult> DeletePlace(int id)
        {
            if (!await _placesRepository.Exist(id))
            {
                return NotFound();
            }

            await _placesRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> ConcertExist(int id)
        {
            return await _placesRepository.Exist(id);

        }
    }
}
