using ShipmentTracker.Core.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ShipmentTracker.Core.Domain.Repository.Contract;

namespace ShipmentTracker.Core.Application.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IVendorService> _vendorService;
        

        public ServiceManager(IVendorRepository vendorRepository ,IMapper mapper )
        {
            _vendorService = new Lazy<IVendorService>(() => new VendorService(vendorRepository, mapper));
        }

        public IVendorService VendorService => _vendorService.Value;
    }
}
