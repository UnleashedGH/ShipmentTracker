using EasyRepository.EFCore.Abstractions;

namespace ShipmentTracker.Core.Domain.Entities
{
    public  class Cargo : EasyBaseEntity<Guid>
    {
        public string CargoNumber { get; protected set; } = "";
        public Guid VendorGuid { get; protected set; }
        public Vendor Vendor { get; set; } // Navigation property

        public decimal NetWeight { get; protected set; }
        public decimal TotalVolume { get; protected set;}
        public decimal ShippingCost { get;  set;}
        public Guid? ShipmentGuid { get; set;}
        public Shipment? Shipment { get; set; } // Navigation property

    }
}
