using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Infrastructure.Presistance.EntityConfiguration;

public class CountryConfiguration
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
            builder.HasOne(e => e.Zone)
            .WithOne(e => e.Country)
            .HasForeignKey<Zone>(e => e.CountryId)
            .IsRequired();
    }
}