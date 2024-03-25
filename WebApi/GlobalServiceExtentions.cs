using Microsoft.AspNetCore.Mvc;
using ShipmentTracker.Core.Application.Extentions;
using ShipmentTracker.Infrastructure.Presistance.Extentions;
using ShipmentTracker.InfrastructureContract.Extentions;

namespace WebApi
{
    public static class GlobalServiceExtentions
    {


        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddCoreApplicationServices();
            services.AddCoreContractServices();
            return services;
        }
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddInfrastructurePresistanceServices();
            return services;
        }

        public static void ConfigureVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
            });
        }

    }
}
