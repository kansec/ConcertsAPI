using ConcertsAPI.Contracts;
using MaxMind.GeoIP2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcertsAPI.Data;
using ConcertsAPI.Models.Concerts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ConcertsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcertsController : ControllerBase
    {
        private readonly IConcertsRepository _concertsRepository;
        private readonly IMapper _mapper;

        public ConcertsController(IConcertsRepository concertsRepository, IMapper mapper)
        {
            _concertsRepository = concertsRepository;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Concert>>> GetConcerts()
        {
            if (await _concertsRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var result = await _concertsRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConcert(int id)
        {
            var result = await _concertsRepository.GetAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<Concert>> PostConcert(CreateConcertDto createConcertDto)
        {
            var concert = _mapper.Map<Concert>(createConcertDto);

            await _concertsRepository.AddAsync(concert);

            return CreatedAtAction("GetConcert", new { id = concert.Id }, concert);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConcert(int id, UpdateConcertDto updateConcertDto)
        {
            if(id != updateConcertDto.Id)
            {
                return BadRequest();
            }

            var concert = await _concertsRepository.GetAsync(id);

            if(concert == null)
            {
                return NotFound();
            }

            _mapper.Map(updateConcertDto, concert);

            try
            {
                await _concertsRepository.UpdateAsync(concert);

            }
            catch (DbUpdateConcurrencyException)
            {
                if(!await _concertsRepository.Exist(id))
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
            if(!await _concertsRepository.Exist(id))
            {
                return NotFound();
            }

            await _concertsRepository.DeleteAsync(id);  

            return NoContent(); 
        }

        private async Task<bool> ConcertExist(int id)
        {
            return await _concertsRepository.Exist(id);

        }
    }
}
