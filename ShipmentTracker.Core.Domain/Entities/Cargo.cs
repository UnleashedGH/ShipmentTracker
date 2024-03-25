using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Cargo : EasyBaseEntity<Guid>
    {
        public string CargoNumber { get; set; }
        public Guid VendorGuid { get; set; }
        public Vendor Vendor { get; set; } // Navigation property

        public decimal NetWeight { get; set; }
        public decimal TotalVolume { get; set;}
        public decimal ShippingCost { get; set;}
        public Guid ShipmentGuid { get; set;}
        public Shipment Shipment { get; set; } // Navigation property

    }
}
