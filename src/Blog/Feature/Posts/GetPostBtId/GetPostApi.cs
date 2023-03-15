using Blog.Api;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Feature.Posts.GetPostBtId;

[ApiController]
public class GetPostApi : ControllerBase
{
    private readonly IGetPostByIdService _service;

    public GetPostApi(IGetPostByIdService service)
    {
        _service = service;
    }
    [HttpGet(Routes.Post + "{id}")]
    public async Task<IActionResult>GetPost([FromRoute] int id)
    {
       return Ok(await _service.GetPostById());
    }
}
