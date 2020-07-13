using BusinessLayer.Abstracts;
using BusinessLayer.Infrastructure;
using BusinessLayer.Models;
using BusinessLayer.Models.ResultModels;

namespace BusinessLayer.Services
{
    public class MathService : IMathService
    {
        private readonly IQueryParser _queryParser;

        public MathService(IQueryParser queryParser)
        {
            _queryParser = queryParser;
        }

        public ICalculationResult Calculate(string query)
        {
            var tree =_queryParser.Parse(query);
            int totalCount = CalculateTotal(tree);

            var result = new CalculationResultWithColor() { Result = totalCount, ResultColor = "green" };

            return result;
        }

        private int CalculateTotal(OperationNode<int> note)
        {
            //TODO need to implement correct tree handling
            if (note.Next == null)
                return 0;

            var total = note.Operation.Calculate(note.Param, note.Next.Param);

            return total;
        }
    }
}
