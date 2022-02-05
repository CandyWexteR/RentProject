using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core
{//TODO:Доработать сущность машины
    public class CarEntity
    {
        public Guid Id { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public bool IsMechanic { get; set;}
        


    }
}
