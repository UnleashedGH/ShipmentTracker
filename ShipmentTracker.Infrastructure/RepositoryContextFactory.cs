using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ShipmentTracker.Infrastructure.Presistance.Repository;

namespace ShipmentTracker.Infrastructure.Presistance;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
        optionsBuilder.UseSqlServer("server=.;database=ShipmentTracker;trusted_connection=true;TrustServerCertificate=true;");

        return new RepositoryContext(optionsBuilder.Options);    }
}