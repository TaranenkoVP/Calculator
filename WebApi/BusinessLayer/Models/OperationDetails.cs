using CalculationService.Interface;

namespace BusinessLayer.Models
{
    public class OperationDetails : IOperationDetails
    {
        public string OperationType { get; set; }
        public int Parameter1 { get; set; }
        public int Parameter2 { get; set; }
    }
}
