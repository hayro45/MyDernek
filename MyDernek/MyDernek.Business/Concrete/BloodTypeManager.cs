using MyDernek.Business.Abstract;
using MyDernek.DataAccess.Concrete.AdoNet;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Concrete
{
    public class BloodTypeManager : IBloodTypeService
    {

        private BloodTypeRepository _bloodTypeRepository;
        public BloodTypeManager(string conString)
        {
            _bloodTypeRepository = new BloodTypeRepository(conString);
        }
        public void Add(BloodType entity)
        {
            //İş kodları yazılacak
            _bloodTypeRepository.Add(entity);
        }

        public void Delete(BloodType entity)
        {
            //İş kodları yazılacak  
            _bloodTypeRepository.Delete(entity);
        }

        public BloodType Get(string id)
        {
            //İş kodları yazılacak
            return _bloodTypeRepository.Get(id);
        }

        public List<BloodType> GetAll(string filter = null)
        {
            //İş kodları yazılacak
            return _bloodTypeRepository.GetAll();
        }

        public void Update(BloodType entity)
        {
            //İş kodları yazılacak
            _bloodTypeRepository.Update(entity);
        }
    }
}
