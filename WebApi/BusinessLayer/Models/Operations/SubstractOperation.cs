using CalculationService.Abstracts;

namespace CalculationService.Models
{
    public class SubstractOperation : IOperation
    {
        public string Symbol => "-";

        public int Calculate(int parameter1, int parameter2)
        {
            return parameter1 - parameter2;
        }
    }
}
