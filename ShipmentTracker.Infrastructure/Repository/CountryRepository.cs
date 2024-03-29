using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class CountryRepository : BaseRepository<Country> , ICountryRepository
{
    public CountryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Country> GetAllCountries(bool trackChanges)
    {
        var result = GetAll(trackChanges).OrderBy(c => c.CountryName).ToList();
        return result;    }
}