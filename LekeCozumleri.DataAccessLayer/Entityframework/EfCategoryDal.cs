using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Context;
using LekeCozumleri.DataAccessLayer.GenericRepository;
using LekeCozumleri.Entities.Concretes;
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
    }
}
