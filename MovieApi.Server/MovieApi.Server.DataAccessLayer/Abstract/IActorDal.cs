using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.Abstract
{
    public interface IActorDal : IGenericDal<Actor>
    {
        Task<Actor?> GetActorWithMovieByAsync(int id);
    }
}
