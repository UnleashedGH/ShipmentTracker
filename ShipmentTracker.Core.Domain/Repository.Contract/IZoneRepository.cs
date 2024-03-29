using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface IZoneRepository
{
    IEnumerable<Zone> GetAllZones(bool trackChanges);
    
}