using Blog.Modules.Post.CreatePost;
using Blog.Modules.Post.GetPostBtId;
using Blog.Modules.Post.GetPostsByFilter;
using Blog.Modules.Post.UpdatePost;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Modules.Post;

[ApiController]
[Route("posts/")]
public class PostController : ControllerBase
{
    private readonly IGetPostByIdHandler _getPostByIdHandler;
    private readonly IGetPostsByFilterHandler _getPostsByFilterHandler;
    private readonly ICreatePostHandler _createPostHandler;
    private readonly IUpdatePostHandler _updatePostHandler;

    public PostController(IGetPostByIdHandler getPostByIdHandler,
        IGetPostsByFilterHandler getPostsByFilterHandler,
        ICreatePostHandler createPostHandler,
        IUpdatePostHandler updatePostHandler)
    {
        _getPostByIdHandler = getPostByIdHandler;
        _getPostsByFilterHandler = getPostsByFilterHandler;
        _createPostHandler = createPostHandler;
        _updatePostHandler = updatePostHandler;
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
        return Ok(await _getPostByIdHandler.GetPostById(id));
    }

    [HttpGet]
    public async Task<IActionResult> GetPostsByFilter([FromQuery] GetPostsRequest request)
    {
        return Ok(await _getPostsByFilterHandler.GetPostByFilter());
    }

    [HttpPatch]
    public async Task<IActionResult> UpdatePost([FromBody] UpdatePostRequest request)
    {
        return Ok(await _updatePostHandler.UpdatePost(new UpdatePostCommand(request.Id, request.Title, request.Body)));
    }
}