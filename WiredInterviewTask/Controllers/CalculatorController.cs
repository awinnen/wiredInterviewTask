using Microsoft.AspNetCore.Mvc;
using WiredInterviewTask.Services;

namespace WiredInterviewTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculatorService calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            this.calculatorService = calculatorService;
        }

        [HttpPost("add", Name = "Add")]
        public IActionResult Add([FromBody] int number)
        {
            return Ok(this.calculatorService.Add(number));
        }

        [HttpGet("result", Name = "result")]
        public IActionResult Result()
        {
            return Ok(this.calculatorService.Result());
        }
    }
}