using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void AddAsync(T entity);
        void DeleteAsync(T entity);
        void UpdateAsync(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
