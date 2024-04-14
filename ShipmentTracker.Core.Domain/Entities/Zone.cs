using EasyRepository.EFCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Zone : EasyBaseEntity<Guid>
    {

        public string Name { get; set; }
        public ShipmentPlanDetail FromZoneShipmentPlanDetail { get; set; } = new ShipmentPlanDetail();
        public ShipmentPlanDetail ToZoneShipmentPlanDetail { get; set; } = new ShipmentPlanDetail();
        public Country Country { get; set; } = new Country();
        public Guid CountryId { get; set; }
        public decimal Longitude { get; set; }
        
        public decimal Latitude { get; set; }
    }
}
