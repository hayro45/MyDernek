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
    public class MemberPaymentStatusManager:IMemberPaymentStatusService
    {
        private MemberPaymentStatusRepository _memberPaymentStatusRepository;
        public MemberPaymentStatusManager(string conString)
        {
            _memberPaymentStatusRepository = new MemberPaymentStatusRepository(conString);
        }
        public List<MemberPaymentStatus> GetMembersPastPaymentsBtwTwoDate(DateTime startDate, DateTime endDate)
        {
            List<MemberPaymentStatus> memberPaymentStatues = new List<MemberPaymentStatus>();
            foreach (var member in _memberPaymentStatusRepository.GetAll())
            {
                if (member.PaymentDate >= startDate && member.PaymentDate <= endDate)
                {
                    memberPaymentStatues.Add(member);
                }
            }
            return memberPaymentStatues;
        }
        public void Add(MemberPaymentStatus entity)
        {
            //iş Kodları yazılacak
            
            _memberPaymentStatusRepository.Add(entity);
        }

        public void Delete(MemberPaymentStatus entity)
        {
            //iş Kodları yazılacak
            _memberPaymentStatusRepository.Delete(entity);
        }

        public MemberPaymentStatus Get(string TcKimlik)
        {
            //iş Kodları yazılacak
            return _memberPaymentStatusRepository.Get(TcKimlik);
        }

        public List<MemberPaymentStatus> GetAll(string filter = null)
        {
            //iş Kodları yazılacak
            return _memberPaymentStatusRepository.GetAll(filter);
        }

        public void Update(MemberPaymentStatus entity)
        {
            //iş Kodları yazılacak
            _memberPaymentStatusRepository.Update(entity);
        }

        public List<MemberPaymentStatus> GetMemberPaymentStatus(string TcKimlik)
        {
            List<MemberPaymentStatus> memberPaymentStatues = new List<MemberPaymentStatus>();
            foreach(var member in _memberPaymentStatusRepository.GetAll())
            {
                if (member.TcKimlik == TcKimlik)
                {
                    memberPaymentStatues.Add(member);
                }
            }
            return memberPaymentStatues;
        }
    }
}
