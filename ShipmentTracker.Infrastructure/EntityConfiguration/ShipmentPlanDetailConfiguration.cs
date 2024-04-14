using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Infrastructure.Presistance.EntityConfiguration;

public class ShipmentPlanDetailConfiguration
{
    public void Configure(EntityTypeBuilder<ShipmentPlanDetail> builder)
    {
        builder.HasOne(e => e.ToZone)
            .WithOne(e => e.ToZoneShipmentPlanDetail)
            .HasForeignKey<ShipmentPlanDetail>(e => e.ToZoneId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.FromZone)
            .WithOne(e => e.FromZoneShipmentPlanDetail)
            .HasForeignKey<ShipmentPlanDetail>(e => e.FromZoneId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}