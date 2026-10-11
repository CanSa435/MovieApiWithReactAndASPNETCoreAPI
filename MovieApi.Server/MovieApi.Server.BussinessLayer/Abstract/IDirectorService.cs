using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Abstract
{
    public interface IDirectorService : IGenericService<Director>
    {
        Task<Director?> GetDirectorByMovie(int directorId);
    }
}
