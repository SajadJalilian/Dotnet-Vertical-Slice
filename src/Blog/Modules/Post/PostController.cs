using Blog.Modules.Post.CreatePost;
using Blog.Modules.Post.GetPostBtId;
using Blog.Modules.Post.GetPostsByFilter;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Modules.Post;

[ApiController]
[Route("posts/")]
public class PostController : ControllerBase
{
    private readonly IGetPostByIdHandler _getPostByIdHandler;
    private readonly IGetPostsByFilterHandler _getPostsByFilterHandler;
    private readonly ICreatePostHandler _createPostHandler;

    public PostController(IGetPostByIdHandler getPostByIdHandler,
        IGetPostsByFilterHandler getPostsByFilterHandler,
        ICreatePostHandler createPostHandler)
    {
        _getPostByIdHandler = getPostByIdHandler;
        _getPostsByFilterHandler = getPostsByFilterHandler;
        _createPostHandler = createPostHandler;
    }

    [HttpPost]
    public async Task<IActionResult> CretePost([FromBody] CreatePostRequest request)
    {
        var result = await _createPostHandler.CreatePost(new CreatePostCommand(request.Title, request.Body));
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPost([FromRoute] int id)
    {
        return Ok(await _getPostByIdHandler.GetPostById());
    }

    [HttpGet]
    public async Task<IActionResult> GetPostsByFilter([FromQuery] GetPostsRequest request)
    {
        return Ok(await _getPostsByFilterHandler.GetPostByFilter());
    }
}