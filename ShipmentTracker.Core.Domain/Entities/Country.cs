using EasyRepository.EFCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Entities
{
    public sealed class Country : EasyBaseEntity<Guid>
    {
        public Zone Zone { get; set; } = new Zone();
        public string CountryName { get; set; }
    }
}
