using Blog.Modules.Posts.GetPostBtId;
using Blog.Modules.Posts.GetPostsByFilter;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Modules.Posts;

[ApiController]
[Route(PostsRoutes.Post)]
public class PostController : ControllerBase
{
    private readonly IGetPostByIdService _getPostByIdService;
    private readonly IGetPostsByFilterService _getPostsByFilterService;

    public PostController(IGetPostByIdService getPostByIdService,
        IGetPostsByFilterService getPostsByFilterService)
    {
        _getPostByIdService = getPostByIdService;
        _getPostsByFilterService = getPostsByFilterService;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPost([FromRoute] int id)
    {
        return Ok(await _getPostByIdService.GetPostById());
    }

    [HttpGet]
    public async Task<IActionResult> GetPostsByFilter([FromQuery] GetPostsRequest request)
    {
        return Ok(await _getPostsByFilterService.GetPostByFilter());
    }
}