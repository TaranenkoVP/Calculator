using CalculationService.Abstracts;

namespace CalculationService.Interface
{
    public interface ITwoParamsOperationQuery: IOperationQuery
    {
        int Parameter1 { get; set; }
        int Parameter2 { get; set; }
    }
}
