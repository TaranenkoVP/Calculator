using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculationService.Interface
{
    public interface IMathOperation
    {
        string OperationType { get; set; }
        int Parameter1 { get; set; }
        int Parameter2 { get; set; }
    }
}
