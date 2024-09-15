using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Modelos;
using CategoriaProducto.Domain.Servicios.Strategy;

namespace CategoriaProducto.Domain.Servicios;

public sealed class ProductoServicio
{
    private const double BASE_PORCENTAJE = 100;
    private readonly IEnumerable<IDescuento> descuentos;

    public ProductoServicio(
        IEnumerable<IDescuento> descuentos
    )
    {
        this.descuentos = descuentos;
    }

    private double DescuentoDelProducto(
        double valorProducto
        , TipoCategoria categoria)
    {
        var descuento = descuentos
            .Where(desc => desc.Categoria == categoria)
            .FirstOrDefault();

        double porcentaje = descuento!.Descuento();

        return valorProducto * porcentaje / BASE_PORCENTAJE;
    }

    private static double ValorFinalConDescuento(
        double valorProducto
        , double descuentoDelProducto)
    {
        return valorProducto - descuentoDelProducto;
    }

    public RespuestaProducto RespuestaProducto(
        double valorProducto
        , TipoCategoria categoria 
    )
    {
        var descuento = DescuentoDelProducto(
            valorProducto
            , categoria
        );

        var valorFinalConDescuento = ValorFinalConDescuento(
            valorProducto
            , descuento
        );

        return new RespuestaProducto(
            valorProducto
            , descuento
            , valorFinalConDescuento
        );
    } 
}
