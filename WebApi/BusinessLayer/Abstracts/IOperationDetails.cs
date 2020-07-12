namespace CalculationService.Interface
{
    public interface IOperationDetails
    {
        string OperationType { get; set; }
        int Parameter1 { get; set; }
        int Parameter2 { get; set; }
    }
}
