using AutoMapper;
using ShipmentTracker.Core.Application.Service.Contract;
using ShipmentTracker.Core.Contract.DTO.Vendor;
using ShipmentTracker.Core.Domain.Entities;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Core.Application.Service;

public class VendorService : IVendorService
{
    private readonly IVendorRepository _vendorRepository;
    private readonly IMapper _mapper;

    public VendorService(IVendorRepository vendorRepository , IMapper mapper)
    {
        _vendorRepository = vendorRepository;
        _mapper = mapper;
    }
    public IList<VendorDto> GetVendors()
    {
        var vendors =  _vendorRepository.GetAllVendors(trackChanges: false).ToList();
        return _mapper.Map<IList<VendorDto>>(vendors);
    }

    public VendorDto GetVendor(Guid id)
    {
        var vendor = _vendorRepository.GetByCondition(x => x.Id == id, true).SingleOrDefault();
        if (vendor == null)
            throw new ArgumentException("vendor not found ");
        return _mapper.Map<VendorDto>(vendor);
    }
    public void CreateVendor(CreateVendorDto baseEo)
    {
        Vendor newVendor = _mapper.Map<Vendor>(baseEo);
         _vendorRepository.Create(newVendor);
    }

    public void UpdateVendor(UpdateVendorDto baseEo)
    {
       Vendor updateVendor = _mapper.Map<Vendor>(baseEo);
        _vendorRepository.Create(updateVendor);
    }

    public void DeleteVendor(Guid id)
    {
        var vendor = _vendorRepository.GetByCondition(x => x.Id == id, true).SingleOrDefault();
        if (vendor == null)
            throw new ArgumentException("vendor not found");
        _vendorRepository.Delete(vendor);
    }
}