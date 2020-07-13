using BusinessLayer.Models;

namespace BusinessLayer.Abstracts
{
    public interface IMathService
    {
        ICalculationResult Calculate(string query);
    }
}