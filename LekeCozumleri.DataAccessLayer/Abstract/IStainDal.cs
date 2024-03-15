using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using LekeCozumleri.DtoLayer.Stain;
namespace LekeCozumleri.DataAccessLayer.Abstract
{
    public interface IStainDal : IGenericDal<Stain>
    {
        List<Stain> GetByLast5Stain();
    }
}
