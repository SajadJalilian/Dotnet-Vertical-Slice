using Blog.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    public PostController()
    {
    }

    [HttpGet(Routes.Post + "{id}")]
    public async Task<IActionResult>GetPost([FromRoute] int id)
    {
        var post = new Post
        {
            Id = 1,
            Title = "test",
            Body = "test body"
        };
        return Ok(post);
    }
    
    [HttpGet(Routes.Post)]
    public async Task<IActionResult> GetPosts()
    {
        var post = new List<Post>()
        {
            new ()
            {
                Id = 1,
                Title = "test",
                Body = "test body"
            },
            new ()
            {
                Id = 2,
                Title = "test2",
                Body = "test body2"
            },
            new ()
            {
                Id = 3,
                Title = "test3",
                Body = "test body3"
            },
        };
        return Ok(post);
    }
}
