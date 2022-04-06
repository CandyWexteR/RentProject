using Microsoft.AspNetCore.Mvc;

namespace RentcarProj.ErrorHandling;

[ApiController]
public class ErrorsController : ControllerBase
{
    [Route("/error")]
    protected IActionResult Error() => Problem();
}