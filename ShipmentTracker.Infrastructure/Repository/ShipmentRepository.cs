using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class ShipmentRepository :BaseRepository<Shipment> , IShipmentRepository
{
    public ShipmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Shipment> GetAllShipments(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.ShippingDate).ToList();
        return result;
        
    }
}