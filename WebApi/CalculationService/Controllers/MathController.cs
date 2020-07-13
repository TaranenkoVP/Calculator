using System;
using System.Threading.Tasks;
using BusinessLayer.Abstracts;
using BusinessLayer.Models;
using CalculationService.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet]
        [Route("calculate")]
        public IActionResult Calculate([FromQuery] string query)
        {
            // https://localhost:44397/api/Math/calculate?query=11%2B61 example

            if (string.IsNullOrWhiteSpace(query))
                return BadRequest();

            try
            {
                return new ObjectResult(_mathService.Calculate(query));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}