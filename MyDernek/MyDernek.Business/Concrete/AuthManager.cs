using MyDernek.Business.Abstract;
using MyDernek.DataAccess.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Concrete
{
    public class AuthManager: IAuthService
    {
        private IAuthDal _authDal;
        public AuthManager(IAuthDal authDal)
        {
            _authDal = authDal;
        }
        public bool IsAdmin(string tcKimlik)
        {
            if (tcKimlik == null)
            {
                throw new Exception("TC Kimlik numarası boş olamaz.");
            }
            else
            {
                return _authDal.IsAdmin(tcKimlik);
            }
        }

        public Member Login(string tcKimlik, string password)
        {
            if (MyToolBox.ControlTcKimlik(tcKimlik))
            {
                if (tcKimlik != null || password != null)
                {
                    try
                    {

                        Member member = _authDal.Login(tcKimlik, password);
                        return member;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    
                }
                else
                {
                    throw new Exception("TC Kimlik numarası veya şifre boş olamaz.");
                }
            }
            else
            {
                throw new Exception("TC Kimlik numarası hatalı.");
            }
        }
    }
}
