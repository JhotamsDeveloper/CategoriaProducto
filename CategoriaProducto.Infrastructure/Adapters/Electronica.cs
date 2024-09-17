using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Options;
using CategoriaProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace CategoriaProducto.Infrastructure.Adapters;

internal sealed record class Electronica : IDescuento
{
    private readonly DescuentoOptions descuentoOptions;

    public Electronica(IOptions<DescuentoOptions> descuentoOptions)
    {
        this.descuentoOptions = descuentoOptions.Value;
    }

    public TipoCategoria Categoria => TipoCategoria.Electronica;

    public double Descuento() => descuentoOptions.Electronica;

}
