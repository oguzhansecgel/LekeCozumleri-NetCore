using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LekeCozumleri.BusinessLayer.Abstract
{
    public interface IStainService : IGenericService<Stain>
    {
        public List<Stain> TGetByLast5Stain();
    }
}
