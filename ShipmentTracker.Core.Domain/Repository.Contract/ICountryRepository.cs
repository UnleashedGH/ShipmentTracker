using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Core.Domain.Repository.Contract;

public interface ICountryRepository
{
    IEnumerable<Country> GetAllCountries(bool trackChanges);
}