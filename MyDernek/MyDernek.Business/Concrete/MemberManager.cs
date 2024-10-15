using MyDernek.Business.Abstract;
using MyDernek.DataAccess.Concrete.AdoNet;
using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private MemberRepository _memberRepository;
        public MemberManager(string conString)
        {
            _memberRepository = new MemberRepository(conString);
        }
        
       
        public Member Get(string TcKimlik)
        {
            //tckimlik boş mu kontrol ediliyor 
            if (MyToolBox.ControlTcKimlik(TcKimlik))
            {
                Member member = _memberRepository.Get(TcKimlik);
                if (member != null)
                {
                    //password basit şifreleme geri çevirme işlemi
                    string password = member.UserPassword;
                    string decryptedPassword = "";
                    foreach (char c in password)
                    {
                        decryptedPassword += (char)(c - 1);
                    }
                    member.UserPassword = decryptedPassword;


                    return member;
                }
                else
                {
                    throw new Exception("Bu TC Kimlik numarası ile kayıtlı bir üye yok");
                }
            }
            else 
            { 
                throw new Exception("TC Kimlik numarası hatalı");
            }
        }
        public void Add(Member member)
        {
            bool checkStringParameters = MyToolBox.CheckStringParameters(member.TcKimlik, member.FirstName, member.LastName, member.Email, member.UserPassword);
            
            //üyenin string değerleri boş mu kontrol ediliyor
            if (checkStringParameters)
            {
                //password basit şifreleme işlemi
                string password = member.UserPassword;
                string encryptedPassword = "";
                foreach (char c in password)
                {
                    encryptedPassword += (char)(c + 1);
                }
                member.UserPassword = encryptedPassword;

               
                
                if (MyToolBox.ControlTcKimlik(member.TcKimlik) == true)
                {
                    if (_memberRepository.Get(member.TcKimlik) == null) 
                    {
                        _memberRepository.Add(member);  
                        throw new Exception("Üye kaydı başarılı");
                    }
                    else
                    {
                        throw new Exception("Bu TC Kimlik numarası ile kayıtlı bir üye var");
                    }
                }
                else
                {
                    throw new Exception("TC Kimlik numarası hatalı");
                }
            }
            else
            {
                throw new Exception("Boş parametre hatası");
            }

            
        }

        public void Delete(Member member)
        {
            //iş kuralları yazılacak
            if(member.IsAdmin)
            {
                throw new Exception("Yönetici silinemez");
            }
            else
            {

                _memberRepository.Delete(member);

            }
        }   

        public List<Member> GetAll()
        {
            //iş kuralları yazılacak
            return _memberRepository.GetAll();
        }
        public List<Member> GetMembersByCity(string cityId)
        {
            List<Member> members = new List<Member>();
            foreach (var member in _memberRepository.GetAll())
            {
                if (member.City.CityId == cityId)
                {
                    members.Add(member);
                }
            }
            return members;

        }
        public List<Member> GetMembersByBloodType(string bloodTypeId)
        {
            List<Member> members = new List<Member>();
            foreach (var member in _memberRepository.GetAll())
            {
                if (member.BloodType.BloodTypeId == bloodTypeId)
                {
                    members.Add(member);
                }
            }
            return members;
        }
        public List<Member> GetMembersByStatus(bool isActive)
        {
            List<Member> members = new List<Member>();
            foreach (var member in _memberRepository.GetAll())
            {
                if (member.IsActive == isActive)
                {
                    members.Add(member);
                }
            }
            return members;
        }
        public List<Member> GetAllWithNames()
        {
            //iş kuralları yazılacak
            throw new NotImplementedException();
            //return _memberRepository.GetAllWithNames(); 
        }

        public List<Member> GetMembersWithDebt()
        {
            //iş kuralları yazılacak
            List<Member> members = new List<Member>();
            foreach(var member in _memberRepository.GetAll())
            {
                if (member.DebtAmount > 0)
                {
                    members.Add(member);
                }
            }
            
            return members;

           
        }

        public void Update(Member member)
        {
            //iş kuralları yazılacak
            if (MyToolBox.CheckStringParameters(member.FirstName, member.LastName, member.Email, member.UserPassword))
            {

                _memberRepository.Update(member);   
            }
            else
            {
                throw new Exception("Boş parametre hatası.");
            }
        }
    }
}
