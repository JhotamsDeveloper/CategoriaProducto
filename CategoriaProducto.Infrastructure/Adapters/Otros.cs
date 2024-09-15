using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Servicios.Strategy;

namespace CategoriaProducto.Infrastructure.Adapters
{
    public class Otros : IDescuento
    {
        private const double DESCUENTO = 5;
        public TipoCategoria Categoria =>
            TipoCategoria.Otros;
        public double Descuento() => DESCUENTO;
    }
}
