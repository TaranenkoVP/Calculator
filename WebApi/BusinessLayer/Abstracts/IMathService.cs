using BusinessLayer.Models;
using CalculationService.Interface;

namespace BusinessLayer.Abstracts
{
    public interface IMathService
    {
        OperationResult Calculate(IOperationDetails operationQuery);
    }
}