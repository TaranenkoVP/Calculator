using CalculationService.Abstracts;

namespace CalculationService.Models
{
    public class AdditionOperation : IOperation
    {
        public string Symbol => "+";

        public AdditionOperation()
        {
        }

        public int Calculate(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }
    }
}
