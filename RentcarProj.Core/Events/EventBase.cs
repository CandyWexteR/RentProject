using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentcarProj.BuildingBlocks;

namespace RentcarProj.Core
{
    /// <summary>
    /// Базовое событие.
    /// </summary>
    public class EventBase:Aggregate
           
    {
        protected EventBase(Guid id, DateTime timeStamp):base(id)
        {
            TimeStamp = timeStamp;

        }
        public DateTime TimeStamp { get; set; }
    }

}
