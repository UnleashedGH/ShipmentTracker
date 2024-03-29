using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Repository.Contract
{
    public interface IRepositoryManager
    {
        ICargoRepository Cargo { get; }
        ICountryRepository Country { get; }
        IShipmentRepository Shipment { get; }
        IShipmentPlanRepository ShipmentPlan { get; }
        IShipmentPlanDetailsRepository ShipmentPlanDetail { get; }
        IVendorRepository Vendor { get; }
        IZoneRepository Zone { get; }
        void Save();
    }
}
