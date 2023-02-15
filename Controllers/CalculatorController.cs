using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("addition/{num1:int}/{num2:int}")]
        public int AdditionOperator(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        [HttpGet("difference/{num1:int}/{num2:int}")]
        public int DifferenceOperator(int num1, int num2)
        {
            int difference = Math.Abs(num1 - num2);
            return difference;
        }

        [HttpGet("division/{num1:int}/{num2:int}")]
        public float DivisionOperator(int num1, int num2)
        {
            float division = (float)num1/(float)num2;
            return division;
        }

        [HttpGet("multiplication/{num1:int}/{num2:int}")]
        public int MultipliationOperator(int num1, int num2)
        {
            int multiplication = num1*num2;
            return multiplication;
        }
    }
}
