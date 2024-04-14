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
        public Shipment Shipment { get; set; }
        public Guid ShipmentId { get; set; }
        public Guid FromZoneId { get; set; }
        public Guid ToZoneId { get; set; }
        public string Notes { get; set; }
        public DateTime TotalEta { get; set; }
        public ICollection<ShipmentPlanDetail> ShipmentPlanDetails { get; set; } = new List<ShipmentPlanDetail>(); // Navigation property
    }
}
