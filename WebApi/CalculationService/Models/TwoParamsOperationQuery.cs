using CalculationService.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace CalculationService.Models
{
    public class TwoParamsOperationQuery : BaseOperationQuery, IOperationQuery
    {
        [FromQuery(Name = "parameter1")]
        public int Parameter1 { get; set; }
        [FromQuery(Name = "parameter2")]
        public int Parameter2 { get; set; }
    }
}
