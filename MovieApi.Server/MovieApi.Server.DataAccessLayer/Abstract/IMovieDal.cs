using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.Abstract
{
    public interface IMovieDal : IGenericDal<Movie>
    {
        Task<Movie?> GetMoviesByActorAndDirector(int id);
    }
}
