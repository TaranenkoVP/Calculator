using CalculationService.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class MathOperation : IMathOperation
    {
        public string OperationType { get; set; }
        public int Parameter1 { get; set; }
        public int Parameter2 { get; set; }
    }
}
