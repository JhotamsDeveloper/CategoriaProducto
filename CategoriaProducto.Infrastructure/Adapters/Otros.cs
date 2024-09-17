using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    public sealed record class Otros : IDescuento
    {
        private readonly DescuentoOptions descuentoOptions;

        public Otros(IOptions<DescuentoOptions> descuentoOptions)
        {
            this.descuentoOptions = descuentoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Otros;
        public double Descuento() => descuentoOptions.Otro;
    }
}
