using MyDernek.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDernek.Entities.Concrete
{
    public class City : IEntity
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
    }
}
