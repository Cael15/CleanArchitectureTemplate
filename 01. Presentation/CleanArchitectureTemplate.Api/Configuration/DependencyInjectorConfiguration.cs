using CleanArchitectureTemplate.Application.Features;
using MediatR;
using SegurosSura.Core.Domain.Interfaces;
using SegurosSura.Utils.Telemetry;
using System.Reflection;

namespace CleanArchitectureTemplate.Api.Configuration
{
    public static class DependencyInjectorConfiguration
    {
        public static void UseDependencyInjectorConfiguration(this IServiceCollection service,
            IConfiguration configuration)
        {
            service.AddTelemetry(configuration);
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            var sp = service.BuildServiceProvider();
            var trace = sp.GetService<ITraceHelper>();

            // Handlers
            service.AddScoped<IRequestHandler<GetEntityQuery, IEnumerable<GetEntityModel>>, GetEntityHandler>();

        }

    }
}
