using CalculationService.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculationService.Interface
{
    public interface ITwoParamsMathOperationQuery: IMathOperationQuery
    {
        int Parameter1 { get; set; }
        int Parameter2 { get; set; }
    }
}
