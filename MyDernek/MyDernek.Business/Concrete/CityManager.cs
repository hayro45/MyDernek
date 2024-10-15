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
    public class CityManager: ICityService
    {
        private CityRepository _cityRepository;
        public CityManager(string conString)
        {
            _cityRepository = new CityRepository(conString);
        }

        public void Add(City entity)
        {
            //İş kodları yazılacak
            _cityRepository.Add(entity);
        }

        public void Delete(City entity)
        {
            //İş kodları yazılacak
            _cityRepository.Delete(entity);
        }

        public City Get(string id)
        {
            //İş kodları yazılacak
            return _cityRepository.Get(id);
        }

        public List<City> GetAll(string filter = null)
        {
            //İş kodları yazılacak
            return _cityRepository.GetAll();
        }

        public void Update(City entity)
        {
            //İş kodları yazılacak
            _cityRepository.Update(entity);
        }
    }
    

}
