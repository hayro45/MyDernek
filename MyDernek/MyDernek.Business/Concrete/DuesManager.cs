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
    public class DuesManager : IDuesService
    {
        private DuesRepository _duesRepository;
        public DuesManager(string conString) 
        {
            _duesRepository = new DuesRepository(conString);
        }

        public void Add(Dues entity)
        {
            //iş kuralları yazılacak
            _duesRepository.Add(entity);    
        }

        public void Delete(Dues entity)
        {
            //iş kuralları yazılacak
            _duesRepository.Delete(entity);
        }

        public Dues Get(int month, int year)
        {

            Dues dues = _duesRepository.Get(month, year);
            if (dues != null)
            {
                return dues;
            }
            else
            {
                throw new Exception("Aradığınız aidat eklenmemiş.");
            }
        }

        public List<Dues> GetAll()
        {
            //iş kuralları yazılacak
            return _duesRepository.GetAll();
        }

        public Dues GetById(string id)
        {
            //iş kuralları yazılacak
            return _duesRepository.Get(id);
        }

        public void Update(Dues entity)
        {
            //iş kuralları yazılacak
            _duesRepository.Update(entity); 
        }
    }
}
