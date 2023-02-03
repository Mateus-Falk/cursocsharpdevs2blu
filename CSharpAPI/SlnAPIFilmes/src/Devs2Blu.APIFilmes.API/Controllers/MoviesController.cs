using Devs2Blu.APIFilmes.Domain.DTO;
using Devs2Blu.APIFilmes.Domain.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.APIFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MoviesDTO>>> GetMovies() 
        {
            return _service.FindAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MoviesDTO>> GetMovie(int id)
        {
            return await _service.FindById(id);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(MoviesDTO movie)
        {
            await _service.Save(movie);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<MoviesDTO>> PostMovie(MoviesDTO movie)
        {
            await _service.Save(movie);
            return CreatedAtAction("GetMovie", new { id = movie.id }, movie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
