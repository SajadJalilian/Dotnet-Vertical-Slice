using Ecommerce.Api;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Features.Products.GetPostBtId;

[ApiController]
public class GetProductApi : ControllerBase
{
    private readonly IGetProductByIdService _service;

    public GetProductApi(IGetProductByIdService service)
    {
        _service = service;
    }
    [HttpGet(Routes.Product + "{id}")]
    public async Task<IActionResult>GetPost([FromRoute] int id)
    {
       return Ok(await _service.GetProductById());
    }
}
