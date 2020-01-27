using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : Controller
    {
        
        // GET api/sum/5/5
        [HttpGet("sum/{fistNumber}/{secundNumber}")]
        public IActionResult Sum(string fistNumber, string secundNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secundNumber)) 
            {
                decimal sum = ConvertToDecimal(fistNumber) + ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }
        // GET api/sub/5/5
        [HttpGet("sub/{fistNumber}/{secundNumber}")]
        public IActionResult Sub(string fistNumber, string secundNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secundNumber))
            {
                decimal sum = ConvertToDecimal(fistNumber) - ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }

        // GET api/div/5/5
        [HttpGet("div/{fistNumber}/{secundNumber}")]
        public IActionResult Div(string fistNumber, string secundNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secundNumber))
            {
                decimal sum = ConvertToDecimal(fistNumber) / ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }

        // GET api/mul/5/5
        [HttpGet("mul/{fistNumber}/{secundNumber}")]
        public IActionResult Mul(string fistNumber, string secundNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secundNumber))
            {
                decimal sum = ConvertToDecimal(fistNumber) * ConvertToDecimal(secundNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");

        }

        private decimal ConvertToDecimal(string number)
        {
            decimal valorDecimal;
           
            if (decimal.TryParse(number, out valorDecimal)) 
            {
                return valorDecimal;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}
