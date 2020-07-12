using BusinessLayer.Abstracts;
using BusinessLayer.Models;
using CalculationService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class MathService : IMathService
    {
        private readonly IOperationFactory _operationFactory;

        public MathService(IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory;
        }

        public OperationResult Calculate(IOperationDetails operationQuery)
        {
            var operation = _operationFactory.GetOperation(operationQuery);
            var resultNumber = operation.Calculate();
            var result = new OperationResult() { Result = resultNumber };
            //TODO use automapper
            return result;
        }
    }
}
