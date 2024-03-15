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
using System.Text.Json;
using LekeCozumleri.DtoLayer.Stain;

namespace LekeCozumleri.DataAccessLayer.Entityframework
{
    public class EfStainDal : GenericRepository<Stain>, IStainDal
    {
         
        
        public EfStainDal(LekeContext context) : base(context)
        {
        }

        public List<Stain> GetByLast5Stain()
        {
            var context = new LekeContext();
            return context.Staines
                   .OrderByDescending(s => s.StainId)
                   .Take(5)
                   .ToList();
        }
    }
}
