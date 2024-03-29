using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class ShipmentPlanDetailsRepository : BaseRepository<ShipmentPlanDetail> , IShipmentPlanDetailsRepository
{
    public ShipmentPlanDetailsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<ShipmentPlanDetail> GetDetailsByMasterId(Guid shipmentPlanId , bool trackChanges)
    {
        var result = GetByCondition( c=> c.ShipmentPlanID == shipmentPlanId ,trackChanges).ToList();
        return result;
    }
}