using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IShipmentRepository
{
    IEnumerable<Shipment> GetAllShipments(bool trackChanges);
}