using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.Dtos.DirectorDtos;
using System.Linq;
using System.Collections.Generic;

namespace MovieApi.Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        public async Task<IActionResult> AllDirectors()
        {
            var directors = await _directorService.GetDatas();
            return Ok(directors); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDirectoryByMovie(int id)
        {
            var director = await _directorService.GetDirectorByMovie(id);
            if(director == null)
            {
                return NotFound("Yönetmen Bulunamadı");
            }
            var dto = new DirectorDetailDto
            {
                DirectorID = director.DirectorID,
                DirectorFullName = director.DirectorFullName,
                DirectorBornDate = director.DirectorBornDate,
                DirectorBiography = director.DirectorBiography,
                DirectorOverview = director.DirectorOverview,
                Movies = director.Movies?.Select(x => $"{x.PosterImageUrl} - {x.MovieTitle}").ToList() ?? new List<string>()
            };
            return Ok(dto);
        }
    }
}
