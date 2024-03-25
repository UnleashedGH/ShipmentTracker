using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipmentTracker.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Infrastructure.Presistance.EntityConfiguration
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasMany(v => v.Cargos)
                    .WithOne(c => c.Vendor)
                    .HasForeignKey(c => c.VendorGuid)
                    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
