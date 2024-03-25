using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShipmentTracker.Core.Application.Extentions;
using ShipmentTracker.Core.Domain.Error;
using ShipmentTracker.Core.Domain.Extentions;
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
        
        public static void ConfigureExceptionHandler(this WebApplication app,ILoggerManager logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error.",
                        }.ToString());
                    }
                });
            });
        }

    }
}
