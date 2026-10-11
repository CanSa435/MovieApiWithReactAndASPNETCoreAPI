using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.Dtos.MovieDtos;

namespace MovieApi.Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> AllMovies()
        {
            var movies = await _movieService.GetDatas();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movieWithActorAndDirector = await _movieService.GetMoviesByActorAndDirector(id);
            if (movieWithActorAndDirector == null)
                return NotFound("Film Bulunamadı");
            var dto = new MovieDetailDto
            {
                MovieId = movieWithActorAndDirector.MovieId,
                MovieTitle = movieWithActorAndDirector.MovieTitle,
                OriginalTitle = movieWithActorAndDirector.MovieTitle,
                ReleaseYear = movieWithActorAndDirector.ReleaseYear,
                ReleaseDate = movieWithActorAndDirector.ReleaseDate,
                PosterImageUrl = movieWithActorAndDirector.PosterImageUrl,
                MovieSecond = movieWithActorAndDirector.MovieSecond,
                MovieReview = movieWithActorAndDirector.MovieReview,
                DirectorFullName = movieWithActorAndDirector.Director?.DirectorFullName,
                Categories = movieWithActorAndDirector.Categories.Select(c => c.CategoryName).ToList(),
                Actors = movieWithActorAndDirector.Actors.Select(a => a.ActorFullName).ToList()
            };
            return Ok(dto);
        }
    }
}
