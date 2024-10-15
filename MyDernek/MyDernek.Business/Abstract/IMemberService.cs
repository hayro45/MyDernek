using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Abstract
{
    public interface IMemberService
    {
        Member Get(string TcKimlik);
        List<Member> GetAll();
        List<Member> GetAllWithNames();
        List<Member> GetMembersWithDebt();
        List<Member> GetMembersByCity(string cityId);
        List<Member> GetMembersByBloodType(string bloodTypeId);
        List<Member> GetMembersByStatus(bool isActive);
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
