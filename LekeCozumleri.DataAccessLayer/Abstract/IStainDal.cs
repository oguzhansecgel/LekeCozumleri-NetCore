using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DataAccessLayer.Abstract
{
    public interface IStainDal : IGenericDal<Stain>
    {
        List<Stain> getByStainWithCategory();  
    }
}
