using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.Controllers;

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
