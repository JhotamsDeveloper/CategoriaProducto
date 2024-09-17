using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal sealed record class Ropa : IDescuento
    {
        private readonly DescuentoOptions descuentoOptions;

        public Ropa(IOptions<DescuentoOptions> descuentoOptions)
        {
            this.descuentoOptions = descuentoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Ropa;

        public double Descuento() => descuentoOptions.Ropa;
    }
}
