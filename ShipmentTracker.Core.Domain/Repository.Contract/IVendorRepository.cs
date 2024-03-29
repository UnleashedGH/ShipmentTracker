using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IVendorRepository
{
    IEnumerable<Vendor> GetAllVendors(bool trackChanges);
}