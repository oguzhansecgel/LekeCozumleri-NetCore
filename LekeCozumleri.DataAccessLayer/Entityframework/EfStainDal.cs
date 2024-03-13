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
    public class EfStainDal : GenericRepository<Stain>, IStainDal
    {
         
        
        public EfStainDal(LekeContext context) : base(context)
        {
        }

        public List<Stain> getByStainWithCategory()
        {
            var context = new LekeContext();
            var values = context.Staines.Include(x => x.category).ToList();
            return values;
        }
    }
}
