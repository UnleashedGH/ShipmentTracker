using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Shipment : EasyBaseEntity<Guid>
    {

        public string ShipmentNumber { get; set; }
        public decimal MaxVolume { get; set; }
        public decimal MaxWeight { get; set; }
        public DateTime ShippingDate { get; set; }
        public decimal ShippingCost { get; set; }

        public ICollection<Cargo> Cargos { get; set; } = new List<Cargo>(); // Navigation property



    }
}
