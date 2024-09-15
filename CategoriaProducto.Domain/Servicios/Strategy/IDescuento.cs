using CategoriaProducto.Domain.Enums;

namespace CategoriaProducto.Domain.Servicios.Strategy;

public interface IDescuento
{
    public TipoCategoria Categoria { get; }
    public double Descuento();
}
