
using ShipmentTracker.Core.Contract.DTO.Vendor;

namespace ShipmentTracker.Core.Application.Service.Contract;

public interface IVendorService
{
    IList<VendorDto> GetVendors();
    void CreateVendor(CreateVendorDto baseEo);
    void UpdateVendor(UpdateVendorDto baseEo);
    void DeleteVendor(Guid id);
}