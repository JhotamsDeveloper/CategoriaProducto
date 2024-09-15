using CategoriaProducto.Domain.Servicios.Strategy;
using CategoriaProducto.Infrastructure.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace CategoriaProducto.Infrastructure
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfra(
            this IServiceCollection services
        )
        {
            services.AddScoped<IDescuento, Alimentos>();
            services.AddScoped<IDescuento, Electronica>();
            services.AddScoped<IDescuento, Otros>();
            services.AddScoped<IDescuento, Ropa>();

            return services;
        }
    }
}
