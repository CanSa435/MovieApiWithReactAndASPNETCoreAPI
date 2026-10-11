using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Concrete
{
    public class ActorManager : IActorService
    {
        private readonly IActorDal _actorDal;
        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        public async Task<Actor?> GetActorWithMovieByAsync(int id)
        {
            return await _actorDal.GetActorWithMovieByAsync(id);
        }

        public async Task<Actor> GetData(int id)
        {
            return await _actorDal.GetData(id);
        }

        public async Task<List<Actor>> GetDatas()
        {
            return await _actorDal.GetDatas();
        }
    }
}
