using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

using Model;

namespace Controllers;

// In this scenario, the controller accepts API version 1.0 and 1.1, and for the actions, we have two different Get() methods, one for each version, which we map to using [MapToApiVersion].
// We must now use the [HttpGet] to explicitly tell ASP.NET Core this is for the GET call to this route, as opposed to just using the method name Get() since we have two methods and they
// cannot both have the same method signature.

[ApiController]
[Route("Robot")]
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class RobotController : ControllerBase
{

    [HttpGet]
    [MapToApiVersion("1.0")]
    public IActionResult GetV1_0() => Ok(new Robot() { Id = 1, Name = "Name1.0" });

    [HttpGet]
    [MapToApiVersion("1.1")]
    public IActionResult GetV1_1() => Ok(new Robot() { Id = 2, Name = "Name1.1" });
}
