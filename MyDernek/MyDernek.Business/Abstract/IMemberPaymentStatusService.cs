using MyDernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Business.Abstract
{
    public interface IMemberPaymentStatusService 
    {
        MemberPaymentStatus Get(string TcKimlik);
        List<MemberPaymentStatus> GetAll(string filter = null);
        List<MemberPaymentStatus> GetMembersPastPaymentsBtwTwoDate(DateTime startDate, DateTime endDate);
        List<MemberPaymentStatus> GetMemberPaymentStatus(string TcKimlik);
        void Add(MemberPaymentStatus entity);
        void Update(MemberPaymentStatus entity);
        void Delete(MemberPaymentStatus entity);
    }
}
