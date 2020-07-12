using CalculationService.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculationService.Models
{
    public abstract class BaseMathOperationQuery
    {
        [FromQuery(Name = "operationType")]
        public string OperationType { get; set; }
    }
}
