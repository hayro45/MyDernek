using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(string filter = null);
        T Get(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
