using CalculationService.Interface;

namespace BusinessLayer.Models.Operations
{
    public abstract class BaseTwoParamsOperation
    {
        protected int parameter1;
        protected int parameter2;

        public BaseTwoParamsOperation(IOperationRequest query)
        {
            parameter1 = query.Parameter1;
            parameter2 = query.Parameter2;
        }
    }
}
