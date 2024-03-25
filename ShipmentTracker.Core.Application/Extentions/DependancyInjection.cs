using Microsoft.Extensions.DependencyInjection;
using ShipmentTracker.Core.Application.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Application.Extentions
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddCoreApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, IServiceManager>();
            return services;
        }
    }
}
