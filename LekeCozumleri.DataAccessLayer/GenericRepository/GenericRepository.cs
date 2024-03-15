using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Context;

namespace LekeCozumleri.DataAccessLayer.GenericRepository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly LekeContext _context;

        public GenericRepository(LekeContext context)
        {
            _context = context;
        }


        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }
        public void AddAsync(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteAsync(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }


        public void UpdateAsync(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
