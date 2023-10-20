using Integracijski_Modul.Data.Services;
using Integracijski_Modul.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integracijski_Modul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        public GenresService _genresService;
        public GenresController(GenresService genreservice)
        {
            _genresService = genreservice;
        }

        [HttpGet("get-all-genres")]
        public IActionResult GetAllGenres()
        {
            var allGenres = _genresService.GetAllGenres();
            return Ok(allGenres);
        }

        [HttpGet("get-genre-by-id/{id}")]
        public IActionResult GetGenreById(int id)
        {
            var genre = _genresService.GetGenreById(id);
            return Ok(genre);
        }

        [HttpPost("add-genre")]
        public IActionResult AddGenres([FromBody] GenreVM genre)
        {
            _genresService.AddGenres(genre);
            return Ok();
        }

        [HttpPut("update-genre-by-id/{id}")]
        public IActionResult UpdateGenreById(int id, [FromBody] GenreVM genre)
        {
            var updatedGenre = _genresService.UpdateGenreById(id, genre);
            return Ok(updatedGenre);
        }


        [HttpDelete("delete-genre-by-ud/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _genresService.DeleteGenreById(id);
            return Ok();
        }
    }
}
