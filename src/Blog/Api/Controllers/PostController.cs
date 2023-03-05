using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    public PostController()
    {
    }

    [HttpGet(Routes.Post)]
    public IEnumerable<WeatherForecast> GetPosts()
    {
        return
    }
}
