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
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.HasMany(s => s.Cargos)
                   .WithOne(c => c.Shipment)
                   .HasForeignKey(c => c.ShipmentGuid)
                   .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
