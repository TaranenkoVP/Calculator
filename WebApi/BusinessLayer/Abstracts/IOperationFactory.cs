using CalculationService.Abstracts;
using CalculationService.Interface;

namespace BusinessLayer.Abstracts
{
    public interface IOperationFactory
    {
        IOperation GetOperation(IOperationDetails operationQuery);
    }
}