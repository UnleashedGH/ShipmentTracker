using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class ZoneRepository : BaseRepository<Zone> , IZoneRepository
{
    public ZoneRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Zone> GetAllZones(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.Name).ToList();
        return result;
    }
}