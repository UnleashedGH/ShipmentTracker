using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IShipmentPlanDetailsRepository
{
    IEnumerable<ShipmentPlanDetail> GetDetailsByMasterId(Guid shipmentPlanId , bool trackChanges);
}