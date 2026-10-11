using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Concrete
{
    public class DirectorManager : IDirectorService
    {
        private readonly IDirectorDal _directorDal;

        public DirectorManager(IDirectorDal directorDal)
        {
            _directorDal = directorDal;
        }

        public async Task<Director> GetData(int id)
        {
            return await _directorDal.GetData(id);
        }

        public async Task<List<Director>> GetDatas()
        {
            return await _directorDal.GetDatas();
        }

        public async Task<Director?> GetDirectorByMovie(int directorId)
        {
            return await _directorDal.GetDirectorByMovie(directorId);
        }
    }
}
