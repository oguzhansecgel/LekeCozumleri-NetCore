using LekeCozumleri.BusinessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Abstract;
using LekeCozumleri.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LekeCozumleri.BusinessLayer.Concrete
{
    public class StainManager : IStainService
    {
        private readonly IStainDal _stainDal;

        public StainManager(IStainDal stainDal)
        {
            _stainDal = stainDal;
        }

        public void TAddAsync(Stain entity)
        {
            _stainDal.AddAsync(entity);
        }

        public void TDeleteAsync(Stain entity)
        {
            _stainDal.DeleteAsync(entity);
        }

        public Stain TGetByID(int id)
        {
            return _stainDal.GetByID(id);
        }

        public List<Stain> TGetByLast5Stain()
        {
            return _stainDal.GetByLast5Stain();
        }

        public List<Stain> TGetListAll()
        {
            return _stainDal.GetListAll();
        }

        public void TUpdateAsync(Stain entity)
        {
            _stainDal.UpdateAsync(entity);
        }
    }
}
