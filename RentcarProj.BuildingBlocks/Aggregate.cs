using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.BuildingBlocks
{
    public class Aggregate:AggregateBase<Guid>
    {
        protected Aggregate(Guid id)
        {
            Id = id;
        }
    }
}
