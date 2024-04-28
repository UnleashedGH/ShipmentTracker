using AutoMapper;
using ShipmentTracker.Core.Contract.DTO.Vendor;
using ShipmentTracker.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Contract.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vendor, CreateVendorDto>();
            CreateMap<Vendor, VendorDto>();
        }
    }
}
