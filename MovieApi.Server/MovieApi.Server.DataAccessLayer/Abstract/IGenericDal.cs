using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class 
    {
         Task<List<T>> GetDatas();
         Task<T> GetData(int id);
    }
}
