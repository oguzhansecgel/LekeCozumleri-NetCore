using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TAddAsync(T entity);
        Task TDeleteAsync(T entity);
        Task TUpdateAsync(T entity);
        T TGetByID(int id);
        List<T> TGetListAll();
    }
}
