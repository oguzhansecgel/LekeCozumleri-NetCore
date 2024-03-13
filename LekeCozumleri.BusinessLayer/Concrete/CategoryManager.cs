using LekeCozumleri.BusinessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task TAddAsync(Category entity)
        {
            _categoryDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Category entity)
        {
            _categoryDal.DeleteAsync(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public async Task TUpdateAsync(Category entity)
        {
            _categoryDal.UpdateAsync(entity);   
        }
    }
}
