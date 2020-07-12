﻿using CalculationService.Abstracts;
using CalculationService.Interface;

namespace CalculationService.Models
{
    public class MultiplyOperation : IOperation
    {
        private int parameter1;
        private int parameter2;

        public MultiplyOperation(IMathOperation query)
        {
            parameter1 = query.Parameter1;
            parameter2 = query.Parameter2;
        }

        public int Calculate()
        {
            return parameter1 * parameter2;
        }
    }
}