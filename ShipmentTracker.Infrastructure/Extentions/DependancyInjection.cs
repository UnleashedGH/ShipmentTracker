using Microsoft.Extensions.DependencyInjection;
using ShipmentTracker.Core.Domain.Repository.Contract;
using ShipmentTracker.Infrastructure.Presistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Infrastructure.Presistance.Extentions
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructurePresistanceServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            return services;
        }
    }
}
