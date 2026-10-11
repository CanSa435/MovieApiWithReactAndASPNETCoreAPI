using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.Abstract
{
    public interface IDirectorDal : IGenericDal<Director>
    {
        Task<Director?> GetDirectorByMovie(int directorId);
    }
}
