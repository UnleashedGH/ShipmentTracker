using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface ICargoRepository
{
    IEnumerable<Cargo> GetAllCargoes(bool trackChanges);

}