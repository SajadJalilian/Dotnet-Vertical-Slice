using Ecommerce.Api;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Features.Products.GetPostsByFilter;

[ApiController]
public class GetProductsByFilterApi : ControllerBase
{
    private readonly IGetPostsByFilterService _service;

    public GetProductsByFilterApi(IGetPostsByFilterService service)
    {
        _service = service;
    }

    [HttpGet(Routes.Product)]
    public async Task<IActionResult> GetPostsByFilter()
    {
        return Ok(await _service.GetPostByFilter());
    }
}
