using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class CargoRepository : BaseRepository<Cargo> , ICargoRepository
{
    public CargoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Cargo> GetAllCargoes(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.CargoNumber).ToList();
        return result;    }
}