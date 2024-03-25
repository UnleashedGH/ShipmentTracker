using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Shared.Clock
{
    public class Clock : IClock
    {
        public DateTime GetTime() => DateTime.Now;
    }
}
