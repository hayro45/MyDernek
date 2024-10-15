using MyDernek.DataAccess.Abstract;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.DataAccess.Concrete.AdoNet
{
    public class AuthDal : IAuthDal
    {
        private readonly string _connectionString;
        private MemberRepository _memberRepository;
        public AuthDal(string connectionString) 
        {
            _connectionString = connectionString;
            _memberRepository = new MemberRepository(_connectionString);
        }
        
        public bool IsAdmin(string tcKimlik)
        {
            Member member = _memberRepository.Get(tcKimlik);
            if(member.IsAdmin == true)
            {
                return true;

            }
            return false;
        }

        public Member Login(string tcKimlik, string password)
        {
            
            MemberRepository memberRepository = new MemberRepository(_connectionString);
            
            Member member = memberRepository.Get(tcKimlik);

            if (member != null)
            {
                if (member.TcKimlik == tcKimlik && member.UserPassword == password)
                {
                    return member;
                }
                else
                {
                    throw new Exception("Kullanıcı adı veya şifre yanlış.");
                }
            }
            else
            {
                throw new Exception("Lütfen kayıt yaptırın.");
            }
        }
    }
}
