using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyRepository.EFCore.Abstractions;
using ShipmentTracker.Core.Domain.ValueObjects;


namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Vendor : EasyBaseEntity<Guid>
    {

        public string VendorFirstName { get; private set; }
        public string VendorLastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public ICollection<Cargo> Cargos { get; set; } = new List<Cargo>(); // Navigation property


        public void AddCargo()
        {

        }
        public Vendor()
        {

        }


        public static Vendor Create()
        {
            return new Vendor();
        }

    }
}
