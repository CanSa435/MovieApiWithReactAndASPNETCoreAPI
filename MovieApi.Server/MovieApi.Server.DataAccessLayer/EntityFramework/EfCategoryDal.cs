using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Context;
using MovieApi.Server.DataAccessLayer.Repositories;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(MovieContext context) : base(context)
        {
            
        }
    }
}
