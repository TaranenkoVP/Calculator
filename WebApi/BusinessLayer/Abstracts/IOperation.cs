namespace CalculationService.Abstracts
{
    public interface IOperation
    {
        string Symbol { get; }
        int Calculate(int param1, int param2);
    }
}
