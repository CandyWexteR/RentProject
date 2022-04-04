using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core.Events
{
//TODO:Дописать событие и написать комментарии к событию.
    public class RentIsEnded:EventBase
    {
        protected RentIsEnded(Guid id,DateTime timeStamp) : base(id,timeStamp)
        {

        }
            
    }
}
