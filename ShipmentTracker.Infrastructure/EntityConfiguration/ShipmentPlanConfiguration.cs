using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Infrastructure.Presistance.EntityConfiguration;

public class ShipmentPlanConfiguration
{
    public void Configure(EntityTypeBuilder<ShipmentPlan> builder)
    {
        builder.HasOne(e => e.Shipment)
            .WithOne(e => e.ShipmentPlan)
            .HasForeignKey<ShipmentPlan>(e => e.ShipmentId)
            .IsRequired(false);
        
        builder.HasMany(e => e.ShipmentPlanDetails)
            .WithOne(e => e.ShipmentPlan)
            .HasForeignKey(e=> e.ShipmentPlanId)
            .IsRequired();
    }
}