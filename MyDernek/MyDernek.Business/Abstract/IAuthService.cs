using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Abstract
{
    public interface IAuthService
    {
        Member Login(string tcKimlik, string password);
        bool IsAdmin(string tcKimlik);
    }
}
