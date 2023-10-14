using CleanArchitectureTemplate.Application.DataContext;
using CleanArchitectureTemplate.Application.Features;
using CleanArchitectureTemplate.Application.Persitence;
using CleanArchitectureTemplate.Persistence;
using CleanArchitectureTemplate.Persistence.Repositories;
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

            service.AddSingleton<DapperContext>();
            service.AddControllers();

            // Handlers
            service.AddScoped<IRequestHandler<GetEntityQuery, IEnumerable<GetEntityModel>>, GetEntityHandler>();
            service.AddScoped<IRequestHandler<PostEntityCommand, bool>, PostEntityHandler>();



            // Persitence
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<IEntityRepository, EntityRepository>();
        }
    }
}
