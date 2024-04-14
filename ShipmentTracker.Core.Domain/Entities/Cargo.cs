using EasyRepository.EFCore.Abstractions;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Cargo : EasyBaseEntity<Guid>
    {
        public string CargoNumber { get; set; } = "";
        public Guid VendorGuid { get; set; }
        public Vendor Vendor { get; set; } = new Vendor(); // Navigation property

        public decimal NetWeight { get; set; }
        public decimal TotalVolume { get; set;}
        public decimal ShippingCost { get; set;}
        public Guid? ShipmentGuid { get; set;}
        public Shipment? Shipment { get; set; } // Navigation property

    }
}
