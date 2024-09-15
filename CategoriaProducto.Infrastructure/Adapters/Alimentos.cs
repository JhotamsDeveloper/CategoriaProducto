using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriaProducto.Infrastructure.Adapters
{
    internal class Alimentos : IDescuento
    {
        private const double DESCUENTO = 15;
        public TipoCategoria Categoria => TipoCategoria.Alimentos;

        public double Descuento() => DESCUENTO;
    }
}
