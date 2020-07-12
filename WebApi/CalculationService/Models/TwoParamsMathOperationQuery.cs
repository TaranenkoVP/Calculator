using CalculationService.Abstracts;
using CalculationService.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CalculationService.Models
{
    public class TwoParamsMathOperationQuery : BaseMathOperationQuery, IMathOperationQuery
    {
        [FromQuery(Name = "parameter1")]
        public int Parameter1 { get; set; }
        [FromQuery(Name = "parameter2")]
        public int Parameter2 { get; set; }
    }
}
