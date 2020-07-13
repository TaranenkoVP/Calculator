using BusinessLayer.Abstracts;
using BusinessLayer.Models;
using BusinessLayer.Models.ResultModels;
using CalculationService.Abstracts;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public class MathService : IMathService
    {
        private readonly IEnumerable<IOperation> _operations;

        public MathService(IEnumerable<IOperation> operations)
        {
            _operations = operations;
        }

        public ICalculationResult Calculate(string query)
        {
            //TODO need to implement correct tree handling
            int totalCount = 0;
            bool handlerFound = false;

            foreach(var operation in _operations)
            {
                var position = query.IndexOf(operation.Symbol);
                if (position != -1)
                {
                    var param1 = int.Parse(query.Substring(0, position));
                    var param2 = int.Parse(query.Substring(position + 1));

                    totalCount = operation.Calculate(param1, param2);
                    handlerFound = true;
                }
            }

            if (!handlerFound)
                throw new Exception("Unknown operation!");

            var result = new CalculationResultWithColor() { Result = totalCount, ResultColor = "green" };

            return result;
        }
    }
}
