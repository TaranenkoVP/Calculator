using CalculationService.Abstracts;
using System;

namespace CalculationService.Models
{
    public class DivisionOperation : IOperation
    {
        public string Symbol => "/";

        public DivisionOperation()
        {
        }

        public int Calculate(int parameter1, int parameter2)
        {
            if (parameter2 == 0)
            {
                throw new DivideByZeroException();
            }

            return parameter1 / parameter2;
        }
    }
}
