using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Entities.Concrete
{
    public class MemberPaymentStatus:IEntity
    {
        public int MemberPaymentStatusId { get; set; }
        public string TcKimlik { get; set; } 
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }

        //ilişkiler
        public Member Member { get; set; }
        
    }
}
