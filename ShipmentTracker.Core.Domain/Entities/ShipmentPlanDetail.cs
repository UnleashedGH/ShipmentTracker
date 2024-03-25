using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class ShipmentPlanDetail : EasyBaseEntity<Guid>
    {

        public Guid ShipmentPlanID { get; set; }
        public Guid ToZoneID { get; set; }
        public Guid FromZoneID { get; set; }
        public DateTime ETA { get; set; }
        public DateTime RTA { get; set; }
        public int StatusID { get; set; }
        public int ShippingType { get; set; }
    }
}
