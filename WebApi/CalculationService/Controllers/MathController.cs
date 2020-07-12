using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstracts;
using BusinessLayer.Models;
using CalculationService.Abstracts;
using CalculationService.Interface;
using CalculationService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;
        private readonly ILogger<MathController> _logger;

        public MathController(IMathService mathService, ILogger<MathController> logger)
        {
            _mathService = mathService;
            _logger = logger;
        }

        [HttpGet]
        [Route("calculate")]
        public async Task<OperationFinalResult> Calculate([FromQuery] TwoParamsMathOperationQuery operationQuery)
        {
            //TODO automapper
            var operation = new OperationRequest()
            {
                OperationType = operationQuery.OperationType,
                Parameter1 = operationQuery.Parameter1,
                Parameter2 = operationQuery.Parameter2
            };

            var results = _mathService.Culculate(operation);

            return new OperationFinalResult()
            {
                Result = results.Result,
                ResultColor = results.ResultColor
            };
        }
    }
}
