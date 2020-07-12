using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculationService.Abstracts
{
    public interface IMathOperationQuery
    {
        public string OperationType { get; set; }
    }
}
