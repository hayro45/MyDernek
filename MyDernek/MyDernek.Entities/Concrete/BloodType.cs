using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Entities.Concrete
{
    public class BloodType: IEntity
    {
        public string BloodTypeId { get; set; }
        public string TypeName { get; set; }
    }
}
