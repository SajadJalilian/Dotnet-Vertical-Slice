using Blog.Api;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Feature.Posts.GetPostsByFilter;

[ApiController]
public class GetPostsByFilterApi : ControllerBase
{
    private readonly IGetPostsByFilterService _service;

    public GetPostsByFilterApi(IGetPostsByFilterService service)
    {
        _service = service;
    }

    [HttpGet(Routes.Post)]
    public async Task<IActionResult> GetPostsByFilter()
    {
        return Ok(await _service.GetPostByFilter());
    }
}
