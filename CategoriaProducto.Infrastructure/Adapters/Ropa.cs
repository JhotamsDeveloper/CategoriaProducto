using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal class Ropa : IDescuento
    {
        private const double DESCUENTO = 10;
        public TipoCategoria Categoria => 
            TipoCategoria.Ropa;

        public double Descuento() => DESCUENTO;
    }
}
