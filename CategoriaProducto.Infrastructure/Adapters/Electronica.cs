using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Strategy;

namespace CategoriaProducto.Infrastructure.Adapters;

internal class Electronica : IDescuento
{
    private const double descuento = 20;
    public TipoCategoria Categoria => TipoCategoria.Electronica;

    public double Descuento()
    {
        return descuento;
    }
}
