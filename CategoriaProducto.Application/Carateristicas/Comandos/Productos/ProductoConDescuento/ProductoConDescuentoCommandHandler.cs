using CategoriaProducto.Domain.Modelos;
using CategoriaProducto.Domain.Servicios;
using MediatR;

namespace CategoriaProducto.Application.Carateristicas.Comandos.Productos.ProductoConDescuento;

internal sealed record class ProductoConDescuentoCommandHandler
    : IRequestHandler<ProductoConDescuentoCommand, RespuestaProducto>
{
    private readonly ProductoServicio productoServicio;

    public ProductoConDescuentoCommandHandler(
        ProductoServicio productoServicio)
    {
        this.productoServicio = productoServicio;
    }

    public Task<RespuestaProducto> Handle(
        ProductoConDescuentoCommand request
        , CancellationToken cancellationToken
    )
    {
      
        return Task.FromResult(
            productoServicio.RespuestaProducto(
                request.ValorProducto
                , request.TipoCategoria
            ));
    }
}
