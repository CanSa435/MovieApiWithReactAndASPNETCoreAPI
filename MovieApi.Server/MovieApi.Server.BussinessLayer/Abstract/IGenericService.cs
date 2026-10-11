using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Abstract
{
    public interface IGenericService<T> where T : class 
    {
        Task<List<T>> GetDatas();
        Task<T> GetData(int id);
    }
}
