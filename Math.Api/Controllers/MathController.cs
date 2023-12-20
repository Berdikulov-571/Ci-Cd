using Math.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Math.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public async ValueTask<IActionResult> AddAsync([FromQuery] long a, [FromQuery] long b, [FromServices] IMathService service, CancellationToken cancellationToken = default)
        {
            var result = await service.AddAsync(a, b,cancellationToken);

            return Ok(result);
        }
    }
}
