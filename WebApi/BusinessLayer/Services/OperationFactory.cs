using BusinessLayer.Abstracts;
using CalculationService.Abstracts;
using CalculationService.Interface;
using CalculationService.Models;
using System;

namespace CalculationService.Services
{
    public class OperationFactory : IOperationFactory
    {
        public IOperation GetOperation(IOperationRequest operationQuery)
        {
            //TO DO consider reflection to map OperationType with query model
            if (operationQuery.OperationType.ToLower() == "addition")
                return new AdditionOperation(operationQuery);
            if (operationQuery.OperationType.ToLower() == "substract")
                return new SubstractOperation(operationQuery);
            if (operationQuery.OperationType.ToLower() == "multiply")
                return new MultiplyOperation(operationQuery);
            else
                throw new Exception("Unknown operation type");
        }
    }
}
