using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core
{
    public class EventBase
    
    {
        protected EventBase(Guid id, DateTime timeStamp)
        {
            Id = id;
            TimeStamp = timeStamp;

        }
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}
