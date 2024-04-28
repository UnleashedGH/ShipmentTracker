using Microsoft.AspNetCore.Mvc;
using ShipmentTracker.Core.Contract.DTO.Vendor;
using ShipmentTracker.Core.Application.Service.Contract;

namespace ShipmentTracker.Infrastructure.ApiEndPoints.V1
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseController
    {
        private readonly IServiceManager _serviceManager;

        public VendorController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Get()
        {
           IList<VendorDto> vendors =  _serviceManager.VendorService.GetVendors();
           return Ok(vendors);
        }

        [HttpPost]
        public IActionResult Post(CreateVendorDto newVendor)
        {
             _serviceManager.VendorService.CreateVendor(newVendor);
             return Ok();
        }
    }

}
