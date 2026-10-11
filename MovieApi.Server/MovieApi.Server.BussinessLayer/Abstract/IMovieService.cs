using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Abstract
{
    public interface IMovieService : IGenericService<Movie>
    {
        Task<Movie?> GetMoviesByActorAndDirector(int id);
    }
}
