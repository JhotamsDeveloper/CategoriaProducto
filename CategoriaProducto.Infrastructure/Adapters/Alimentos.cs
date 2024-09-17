using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal record class Alimentos : IDescuento
    {
        private readonly DescuentoOptions descuentoOptions;

        public Alimentos(IOptions<DescuentoOptions> descuentoOptions)
        {
            this.descuentoOptions = descuentoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Alimentos;

        public double Descuento() => descuentoOptions.Alimento;
    }
}
