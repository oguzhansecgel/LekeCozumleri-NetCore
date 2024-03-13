using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
