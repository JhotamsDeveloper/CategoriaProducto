using CategoriaProducto.Domain.Enums;

namespace CategoriaProducto.Domain.Ports;

public interface IDescuento
{
    public TipoCategoria Categoria { get; }
    public double Descuento();
}
