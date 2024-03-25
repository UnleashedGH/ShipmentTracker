using Microsoft.AspNetCore.Mvc;
using ShipmentTracker.Core.Contract.DTO.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Infrastructure.ApiEndPoints.V1
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseController
    {

        [HttpGet]
        public IActionResult Get()
        {
            return null;
        }

        [HttpPost]

        public IActionResult Post(CreateVendorDto DTO)
        {
            return null;
        }
    }

}
