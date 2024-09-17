using CategoriaProducto.Application.Carateristicas.Comandos.Productos.ProductoConDescuento;
using CategoriaProducto.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CategoriaProducto.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly ILogger<ProductoController> _logger;

    public ProductoController(
        ILogger<ProductoController> logger
        , IMediator mediator
    )
    {
        _logger = logger;
        this.mediator = mediator;
    }

    [HttpPost(Name = "descuento")]
    public async Task<IActionResult> Get(
        double valorProducto
        , TipoCategoria categoria)
    {
        var request = new ProductoConDescuentoCommand(
            valorProducto
            , categoria
        );

        return Ok(await mediator.Send(request));
    }
}