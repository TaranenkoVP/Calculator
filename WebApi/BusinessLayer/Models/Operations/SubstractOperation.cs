using BusinessLayer.Models.Operations;
using CalculationService.Abstracts;
using CalculationService.Interface;

namespace CalculationService.Models
{
    public class SubstractOperation : BaseTwoParamsOperation, IOperation
    {
        public SubstractOperation(IOperationRequest query) : base(query) { }

        public int Calculate()
        {
            return parameter1 - parameter2;
        }
    }
}
