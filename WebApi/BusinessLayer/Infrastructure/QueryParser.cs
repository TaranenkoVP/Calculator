using BusinessLayer.Models;
using CalculationService.Abstracts;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Infrastructure
{
    public class QueryParser : IQueryParser
    {
        private readonly IEnumerable<IOperation> _operations;

        public QueryParser(IEnumerable<IOperation> operations)
        {
            _operations = operations;
        }

        public OperationNode<int> Parse(string query)
        {
            var tree = new OperationNode<int>();

            AddChildren(tree, query);

            return tree;
        }

        private void AddChildren(OperationNode<int> node, string query)
        {
            try
            {
                bool symbolFound = false;

                foreach (var operation in _operations)
                {
                    var position = query.IndexOf(operation.Symbol);

                    if (position != -1)
                    {
                        node.Param = int.Parse(query.Substring(0, position));
                        node.Operation = operation;
                        node.Next = new OperationNode<int>();
                        var subquery = query.Substring(position + 1);

                        AddChildren(node.Next, subquery);

                        symbolFound = true;
                    }
                }

                if (!symbolFound)
                {
                    node.Param = int.Parse(query);
                }
            }
            catch (Exception)
            {
                throw new Exception("Unknown operation!");
            }
        }
    }
}
