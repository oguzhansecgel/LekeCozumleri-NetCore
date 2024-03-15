using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAddAsync(T entity);
        void TDeleteAsync(T entity);
        void TUpdateAsync(T entity);
        T TGetByID(int id);
        List<T> TGetListAll();
    }
}
