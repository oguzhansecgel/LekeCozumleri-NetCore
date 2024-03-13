using LekeCozumleri.BusinessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.BusinessLayer.Concrete
{
    public class StainManager : IStainService
    {
        private readonly IStainDal _stainDal;

        public StainManager(IStainDal stainDal)
        {
            _stainDal = stainDal;
        }

        public async Task TAddAsync(Stain entity)
        {
            _stainDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Stain entity)
        {
            _stainDal.DeleteAsync(entity);
        }

        public Stain TGetByID(int id)
        {
            return _stainDal.GetByID(id);
        }

        public List<Stain> TgetByStainWithCategory()
        {
            return _stainDal.getByStainWithCategory();
        }

        public List<Stain> TGetListAll()
        {
            return _stainDal.GetListAll();
        }

        public async Task TUpdateAsync(Stain entity)
        {
            _stainDal.UpdateAsync(entity);
        }
    }
}
