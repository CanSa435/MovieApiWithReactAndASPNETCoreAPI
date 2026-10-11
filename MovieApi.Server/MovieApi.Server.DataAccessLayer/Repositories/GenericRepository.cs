using Microsoft.EntityFrameworkCore;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly MovieContext _context;
        public GenericRepository(MovieContext context)
        {
            _context = context;
        }


        public async Task<T> GetData(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity!;
        }

        public async Task<List<T>> GetDatas()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}

