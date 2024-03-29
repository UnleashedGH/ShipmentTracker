using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class ShipmentPlanRepository : BaseRepository<ShipmentPlan> , IShipmentPlanRepository
{
    public ShipmentPlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<ShipmentPlan> GetAllShipmentPlans(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.ShipmentPlanName).ToList();
        return result;
    }
}