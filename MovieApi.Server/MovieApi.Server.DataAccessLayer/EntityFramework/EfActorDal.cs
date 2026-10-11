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
    public class EfActorDal : GenericRepository<Actor>, IActorDal
    {
        private readonly MovieContext _context;
        public EfActorDal(MovieContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Actor?> GetActorWithMovieByAsync(int id)
        {
            return await _context.Actors
                .AsNoTracking()
                .AsSplitQuery()
                .Include(x => x.Movie)
                .FirstOrDefaultAsync(x => x.ActorId == id);
        }
    }
}

