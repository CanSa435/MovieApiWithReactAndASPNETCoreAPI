using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public async Task<Movie> GetData(int id)
        {
            return await _movieDal.GetData(id);
        }

        public async Task<List<Movie>> GetDatas()
        {
            return await _movieDal.GetDatas();
        }

        public async Task<Movie?> GetMoviesByActorAndDirector(int id)
        {
            return await _movieDal.GetMoviesByActorAndDirector(id);
        }
    }
}
