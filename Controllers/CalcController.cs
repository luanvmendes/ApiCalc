using ApiCalc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalc.Controllers
{
    [ApiController]        
    [Route("/")]
    public class CalcController : ControllerBase
    {
        [HttpPost("Adicionar")]
        public IActionResult Adicionar([FromBody] Calcula calc)
        {
            return Ok(calc.Num1 + calc.Num2);
        }

        [HttpPost("Subtrair")]
        public IActionResult Subtrair([FromBody] Calcula calc)
        {
            return Ok(calc.Num1 - calc.Num2);
        }

        [HttpPost("Dividir")]
        public IActionResult Dividir([FromBody] Calcula calc)
        {
            if (calc.Num2 == 0)
            {
                Response.StatusCode = 406;

                return new ObjectResult ("Não é possível dividir por zero");
            }
            return Ok(calc.Num1 / calc.Num2);
        }

        [HttpPost("Multiplicar")]
        public IActionResult Multiplicar([FromBody] Calcula calc)
        {
            return Ok(calc.Num1 * calc.Num2);
        }
    }
}