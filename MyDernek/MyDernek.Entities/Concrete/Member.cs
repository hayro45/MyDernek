using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Entities.Concrete
{
    public class Member : IEntity
    {
        public string TcKimlik { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string BloodTypeId { get; set; }
        public string CityId { get; set; } 
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public decimal DuesAmount { get; set; }
        public DateTime DueDate { get; set; }
        public decimal DebtAmount { get; set; }

        //ilişkiler
        public City City { get; set; } 
        public BloodType BloodType { get; set; } 
        public ICollection<MemberPaymentStatus> PaymentStatuses { get; set; } //üyenin ödeme durumu koleksiyonu.
        //bir üyenin birden fazla ödeme durumu olabilir.


    }
}
