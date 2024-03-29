using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class VendorRepository : BaseRepository<Vendor> , IVendorRepository
{
    public VendorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Vendor> GetAllVendors(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.VendorFirstName).ToList();
        return result;
    }
}