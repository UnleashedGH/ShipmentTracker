using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IShipmentPlanRepository
{
    IEnumerable<ShipmentPlan> GetAllShipmentPlans(bool trackChanges);
}