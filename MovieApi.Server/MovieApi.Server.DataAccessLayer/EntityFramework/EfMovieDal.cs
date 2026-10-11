using Microsoft.EntityFrameworkCore;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Context;
using MovieApi.Server.DataAccessLayer.Repositories;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.EntityFramework
{
    public class EfMovieDal : GenericRepository<Movie>,IMovieDal
    {
        private readonly MovieContext _movieContext;
        public EfMovieDal(MovieContext context) : base(context)
        {
            _movieContext = context;
        }

        public async Task<Movie?> GetMoviesByActorAndDirector(int id)
        {
            return await _movieContext.Movies
                .AsNoTracking()
                .AsSplitQuery()
                .Include(x => x.Director)
                .Include(x => x.Categories)
                .Include(x => x.Actors)
                .FirstOrDefaultAsync(x => x.MovieId == id);

           
        }
    }
}
