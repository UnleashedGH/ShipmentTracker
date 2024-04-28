using EasyRepository.EFCore.Abstractions;
using ShipmentTracker.Core.Domain.Repository.Contract;


namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Vendor : EasyBaseEntity<Guid>
    {

        public string VendorFirstName { get; private set; }
        public string VendorLastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public ICollection<Cargo> Cargos { get; private set; } = new List<Cargo>(); // Navigation property


        public void AddCargo()
        {

        }
        private Vendor()
        {
            Id = Guid.NewGuid();
            VendorFirstName = "";
            VendorLastName = "";
            Email = "";
            PhoneNumber = "+964";
            Address = "";
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            
        }

        public bool CheckVendorExists(IVendorRepository vendorRepository)
        {
            var result = vendorRepository.GetByName(VendorFirstName, VendorLastName);
            return result != null;
        }
        public static Vendor Create()
        {
            return new Vendor();
        }

    }
}
