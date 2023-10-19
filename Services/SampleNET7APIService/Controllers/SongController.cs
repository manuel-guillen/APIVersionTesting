using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

using Model;

namespace Controllers;

// In this scenario, we have two separate controllers for the same route /Song. One handles version 1.0 and the other handles version 1.1.
// Note, unlike how we did this for RobotController, we can continue using the default convention of the Get() method rather than having to use different method names and tag with [HttpGet] attributes.

[ApiController]
[Route("Song")]
[ApiVersion("1.0")]
public class SongControllerV1_0 : ControllerBase
{

    public IActionResult Get() => Ok(new Song() { Id = 1, SongName = "Name1.0" });

}

[ApiController]
[Route("Song")]
[ApiVersion("1.1")]
public class SongControllerV1_1 : ControllerBase
{

    public IActionResult Get() => Ok(new Song() { Id = 1, SongName = "Name1.1" });

}
