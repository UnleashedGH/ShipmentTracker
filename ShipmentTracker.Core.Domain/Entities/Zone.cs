using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Zone : EasyBaseEntity<Guid>
    {

        public string Name { get; set; }
        public Guid CountryID { get; set; }
        public decimal Longtitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
