namespace CalculationService.Interface
{
    public interface IOperationRequest
    {
        string OperationType { get; set; }
        int Parameter1 { get; set; }
        int Parameter2 { get; set; }
    }
}
