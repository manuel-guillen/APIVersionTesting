using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

using Model;

namespace Controllers;

// In this scenario, "GET /Person" will map to the singular method of this controller with API version 1.0 or 1.1. The HTTP call will fail otherwise.

[ApiController]
[Route("Person")]
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class PersonController : ControllerBase
{

    public IActionResult Get() => Ok(new Person() { Id = 1, Name = "Name" });
}
