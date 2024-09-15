namespace CategoriaProducto.Domain.Modelos;

public record RespuestaProducto(
    double ValorProducto
    , double Descuento
    , double ValorFinalConDescuento
);