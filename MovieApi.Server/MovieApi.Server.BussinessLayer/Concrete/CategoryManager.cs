using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task<Category> GetData(int id)
        {
            return await _categoryDal.GetData(id);
        }

        public async Task<List<Category>> GetDatas()
        {
            return await _categoryDal.GetDatas();
        }
    }
}
