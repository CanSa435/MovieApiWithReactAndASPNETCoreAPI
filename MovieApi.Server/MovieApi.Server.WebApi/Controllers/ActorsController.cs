using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.Dtos.ActorDtos;

namespace MovieApi.Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _actorService;
        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;            
        }

        [HttpGet]
        public async Task<IActionResult> AllActors()
        {
            return Ok(await _actorService.GetDatas());
        }

         
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActorByMovie(int actorId) 
        {
            var actorWithMovie = await _actorService.GetActorWithMovieByAsync(actorId);
            if(actorWithMovie == null)
            {
                return BadRequest("Aktör Bulunamadı");
            }
            var dto = new ActorDetailDto
            {
                ActorId = actorWithMovie.ActorId,
                ActorFullName = actorWithMovie.ActorFullName,
                BornDate = actorWithMovie.BornDate,
                ActorBiography = actorWithMovie.ActorBiography,
                ActorImage = actorWithMovie.ActorImage,
                MovieTitle = actorWithMovie?.Movie?.MovieTitle,
                MoviePosterImage = actorWithMovie?.Movie?.PosterImageUrl
            };
            return Ok(dto);
        }
    }
}
