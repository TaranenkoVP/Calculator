using BusinessLayer.Models;

namespace BusinessLayer.Abstracts
{
    public interface IMathService
    {
        OperationResult Calculate(string query);
    }
}