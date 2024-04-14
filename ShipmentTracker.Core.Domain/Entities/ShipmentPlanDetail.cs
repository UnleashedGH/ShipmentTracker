using EasyRepository.EFCore.Abstractions;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class ShipmentPlanDetail : EasyBaseEntity<Guid>
    {
        public ShipmentPlan ShipmentPlan { get; set; } = new ShipmentPlan();
        public Guid ShipmentPlanId { get; set; }
        public Zone ToZone { get; set; } = new Zone();
        public Guid ToZoneId { get; set; }
        public Zone FromZone { get; set; } = new Zone();
        public Guid FromZoneId { get; set; }
        public DateTime ETa { get; set; }
        public DateTime RTa { get; set; }
        public int StatusId { get; set; }
        public int ShippingType { get; set; }
    }
}
