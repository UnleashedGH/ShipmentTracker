using System.Reflection;
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
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=ShipmentTracker;trusted_connection=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vendor>()
            .HasMany(e => e.Cargos)
            .WithOne(e => e.Vendor)
            .HasForeignKey(e=> e.VendorGuid)
            .IsRequired(false);
        
        modelBuilder.Entity<Shipment>()
            .HasMany(e => e.Cargos)
            .WithOne(e => e.Shipment)
            .HasForeignKey(e=> e.ShipmentGuid)
            .IsRequired();
        
        modelBuilder.Entity<ShipmentPlan>()
            .HasOne(e => e.Shipment)
            .WithOne(e => e.ShipmentPlan)
            .HasForeignKey<ShipmentPlan>(e => e.ShipmentId)
            .IsRequired(false);
        
        modelBuilder.Entity<ShipmentPlan>()
            .HasMany(e => e.ShipmentPlanDetails)
            .WithOne(e => e.ShipmentPlan)
            .HasForeignKey(e=> e.ShipmentPlanId)
            .IsRequired();
        
        modelBuilder.Entity<ShipmentPlanDetail>()
            .HasOne(e => e.ToZone)
            .WithOne(e => e.ToZoneShipmentPlanDetail)
            .HasForeignKey<ShipmentPlanDetail>(e => e.ToZoneId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ShipmentPlanDetail>()
            .HasOne(e => e.FromZone)
            .WithOne(e => e.FromZoneShipmentPlanDetail)
            .HasForeignKey<ShipmentPlanDetail>(e => e.FromZoneId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
   
        
        modelBuilder.Entity<Country>()
            .HasOne(e => e.Zone)
            .WithOne(e => e.Country)
            .HasForeignKey<Zone>(e => e.CountryId)
            .IsRequired();
    }
    public DbSet<Cargo> Cargoes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<ShipmentPlan> ShipmentPlans { get; set; }
    public DbSet<ShipmentPlanDetail> ShipmentPlanDetails { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Zone> Zones { get; set; } }