using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Application.Service.Contract
{
    public interface IServiceManager
    {
        IVendorService VendorService { get; }
    }
}
