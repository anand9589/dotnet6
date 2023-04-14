using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorController : ControllerBase
{
    [Route("Error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
