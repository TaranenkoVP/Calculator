using CalculationService.Abstracts;
using CalculationService.Interface;
using CalculationService.Models;

namespace BusinessLayer.Abstracts
{
    public interface IOperationFactory
    {
        IOperation GetStrategy(IMathOperation operationQuery);
    }
}