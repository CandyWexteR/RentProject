using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core
{
    public class CarIsRented:EventBase
    {
        protected CarIsRented(Guid id, DateTime timeStamp) : base(id, timeStamp)
        {
        }

        public string UserData { get; set; }
        public Guid CarId  { get; set; }

    }
}
