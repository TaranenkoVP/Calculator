using Microsoft.AspNetCore.Mvc;

namespace CalculationService.Models
{
    public abstract class BaseOperationQuery
    {
        [FromQuery(Name = "operationType")]
        public string OperationType { get; set; }
    }
}
