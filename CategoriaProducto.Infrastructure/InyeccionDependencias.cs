using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using CategoriaProducto.Infrastructure.Adapters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CategoriaProducto.Infrastructure
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfra(
            this IServiceCollection services
            , IConfiguration configuration
        )
        {
            services.AddScoped<IDescuento, Alimentos>();
            services.AddScoped<IDescuento, Electronica>();
            services.AddScoped<IDescuento, Otros>();
            services.AddScoped<IDescuento, Ropa>();


            services.Configure<DescuentoOptions>(
                configuration.GetSection(
                    DescuentoOptions.Fact.SectionName
                )
            );

            return services;
        }
    }
}
