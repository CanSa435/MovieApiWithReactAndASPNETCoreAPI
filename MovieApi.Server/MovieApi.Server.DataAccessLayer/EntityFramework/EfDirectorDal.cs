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
    public class EfDirectorDal : GenericRepository<Director>,IDirectorDal
    {
        private readonly MovieContext _context;
        public EfDirectorDal(MovieContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Director?> GetDirectorByMovie(int directorId)
        {
            return await _context.Directors
                .AsNoTracking()
                .AsSplitQuery()
                .Include(x => x.Movies)
                .FirstOrDefaultAsync(x => x.DirectorID == directorId);
        }
    }
}
