using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShipmentTracker.Core.Domain.Entities;

namespace ShipmentTracker.Infrastructure.Presistance.Repository;

public class RepositoryContext : IdentityDbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Cargo> Cargoes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<ShipmentPlan> ShipmentPlans { get; set; }
    public DbSet<ShipmentPlanDetail> ShipmentPlanDetails { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Zone> Zones { get; set; } }