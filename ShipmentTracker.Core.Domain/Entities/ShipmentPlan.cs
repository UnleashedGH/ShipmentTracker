using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class ShipmentPlan : EasyBaseEntity<Guid>
    {

        public string ShipmentPlanName { get; set; }
        public Guid ShipmentID { get; set; }
        public Guid FromZoneID { get; set; }
        public Guid ToZoneID { get; set; }
        public string Notes { get; set; }
        public DateTime TotalETA { get; set; }
    }
}
