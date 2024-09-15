using CategoriaProducto.Domain.Enums;
using CategoriaProducto.Domain.Modelos;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CategoriaProducto.Application.Carateristicas.Comandos.Productos.ProductoConDescuento;

public record ProductoConDescuentoCommand(
    [Required] double ValorProducto
    , [Required] TipoCategoria TipoCategoria
): IRequest<RespuestaProducto>;