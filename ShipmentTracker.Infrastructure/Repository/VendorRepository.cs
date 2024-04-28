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

    public Vendor GetById(Guid id)
    {
        var result = GetByCondition(x => x.Id == id , true).SingleOrDefault();
        if (result == null)
            throw new ArgumentException("Vendor not found");
        return result;
    }

    public Vendor? GetByName(string vendorFirstName , string vendorLastName)
    {
        var result = GetByCondition(x => x.VendorFirstName == vendorFirstName && x.VendorLastName == vendorLastName, true)
            .SingleOrDefault();
        
        return result;
    }
}