using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    public ExampleController()
    {
    }

    [HttpGet]
    public ActionResult GetHelloWorld()
    {
        return Ok("Hello world from Web API");
    }
}
