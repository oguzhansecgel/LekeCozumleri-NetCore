using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.BusinessLayer.Abstract
{
    public interface IStainService : IGenericService<Stain>
    {
        List<Stain> TgetByStainWithCategory();
    }
}
