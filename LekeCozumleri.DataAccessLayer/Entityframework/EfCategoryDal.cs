using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Context;
using LekeCozumleri.DataAccessLayer.GenericRepository;
using LekeCozumleri.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DataAccessLayer.Entityframework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(LekeContext context) : base(context)
        {
        }

        public List<Stain> GetStainsByCategoryId(int categoryId)
        {
            var _context = new LekeContext();
            return _context.Categories
                            .Where(c => c.CategoryId == categoryId)
                            .Include(c => c.Stain)
                            .SelectMany(c => c.Stain)
                            .ToList();
        }
    }
}
