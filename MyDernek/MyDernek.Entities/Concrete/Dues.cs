using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Entities.Concrete
{
    public class Dues:IEntity
    {
        public int DuesId { get; set; }
        public int DuesYear { get; set; }
        public int DuesMonth { get; set; }
        public int DuesAmount { get; set; }
    }
}
