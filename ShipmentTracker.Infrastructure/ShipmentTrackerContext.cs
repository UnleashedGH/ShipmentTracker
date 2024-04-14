using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShipmentTracker.Core.Domain.Entities;



//namespace ShipmentTracker.Infrastructure.Presistance
//{
//    public class ShipmentTrackerContext : DbContext
//    {
//        public DbSet<Cargo>? Cargos { get; set; }
//        public DbSet<Country>? Countries { get; set; }
//        public DbSet<Shipment>? Shipments { get; set; }
//        public DbSet<ShipmentPlan>? ShipmentPlans { get; set; }
//        public DbSet<ShipmentPlanDetail>? ShipmentPlanDetails { get; set; }
//        public DbSet<Vendor>? Vendors { get; set; }
//        public DbSet<Zone>? Zones { get; set; }
//
//
//        public ShipmentTrackerContext(DbContextOptions<ShipmentTrackerContext> options) : base(options)
//        {
//
//        }
//
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
//        }
//    }
//
//}
