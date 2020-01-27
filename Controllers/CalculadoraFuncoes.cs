using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraFuncoes : Controller
    {

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
