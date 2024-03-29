using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Infrastructure.Presistance.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICargoRepository> _cargoRepository;
        private readonly Lazy<ICountryRepository> _countryRepository;
        private readonly Lazy<IShipmentRepository> _shipmentRepository;
        private readonly Lazy<IShipmentPlanRepository> _shipmentPlanRepository;
        private readonly Lazy<IShipmentPlanDetailsRepository> _shipmentPlanDetailRepository;
        private readonly Lazy<IVendorRepository> _vendorRepository;
        private readonly Lazy<IZoneRepository> _zoneRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _cargoRepository = new Lazy<ICargoRepository>(() => new CargoRepository(repositoryContext));
            _countryRepository = new Lazy<ICountryRepository>(() => new CountryRepository(repositoryContext));
            _shipmentRepository = new Lazy<IShipmentRepository>(() => new ShipmentRepository(repositoryContext));
            _shipmentPlanRepository = new Lazy<IShipmentPlanRepository>(() => new ShipmentPlanRepository(repositoryContext));
            _shipmentPlanDetailRepository = new Lazy<IShipmentPlanDetailsRepository>(() => new ShipmentPlanDetailsRepository(repositoryContext));
            _vendorRepository = new Lazy<IVendorRepository>(() => new VendorRepository(repositoryContext));
            _zoneRepository = new Lazy<IZoneRepository>(() => new ZoneRepository(repositoryContext));

        }

        public ICargoRepository Cargo => _cargoRepository.Value;
        public ICountryRepository Country => _countryRepository.Value;
        public IShipmentRepository Shipment => _shipmentRepository.Value;
        public IShipmentPlanRepository ShipmentPlan => _shipmentPlanRepository.Value;
        public IShipmentPlanDetailsRepository ShipmentPlanDetail => _shipmentPlanDetailRepository.Value;
        public IVendorRepository Vendor => _vendorRepository.Value;
        public IZoneRepository Zone => _zoneRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();

    }
}
