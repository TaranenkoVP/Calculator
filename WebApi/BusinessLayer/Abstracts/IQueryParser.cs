using BusinessLayer.Models;

namespace BusinessLayer.Infrastructure
{
    public interface IQueryParser
    {
        OperationNode<int> Parse(string query);
    }
}