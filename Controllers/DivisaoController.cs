using Divisao.Exceptions;
using Divisao.Services;
using Divisao.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Divisao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisaoController : ControllerBase
    {

        [HttpGet("/dividir/executar")]
        public IActionResult divisao([FromQuery] double dividendo, [FromQuery] double divisor,
            [FromServices] IDivisaoService divisaoService)
        {

            try
            {
                double resultado = divisaoService.calculate(dividendo, divisor);
                return Ok(new DivisaoResponse(resultado, ""));
            }
            catch (DivisaoZeroException e)
            {
                return BadRequest(new DivisaoResponse(0, e.Message));
            }
        }
    }
}