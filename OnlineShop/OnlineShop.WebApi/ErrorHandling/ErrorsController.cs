using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.WebApi.ErrorHandling;

[ApiController]
public class ErrorsController : ControllerBase
{
    [Route("/error")]
    protected IActionResult Error() => Problem();
}