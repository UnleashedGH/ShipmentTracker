using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShipmentTracker.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Infrastructure.Presistance.EntityConfiguration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {

            builder.HasOne(c => c.Vendor)
                    .WithMany(v => v.Cargos)
                    .HasForeignKey(c => c.VendorGuid)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Shipment)
                   .WithMany(s => s.Cargos)
                   .HasForeignKey(c => c.ShipmentGuid)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
