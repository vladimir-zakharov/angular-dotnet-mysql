using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        return "Hello World";
    }
}
