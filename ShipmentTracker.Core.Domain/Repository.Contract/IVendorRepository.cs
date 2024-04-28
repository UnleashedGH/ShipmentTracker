using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IVendorRepository : IBaseRepository<Vendor>
{
    IEnumerable<Vendor> GetAllVendors(bool trackChanges);
    Vendor GetById(Guid id);
    Vendor? GetByName(string vendorFirstName , string vendorLastName);
}