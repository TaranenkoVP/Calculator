using CalculationService.Abstracts;

namespace BusinessLayer.Models
{
    public class OperationNode<T>
    {
        public T Param { get; set; }
        public IOperation Operation { get; set; }
        public OperationNode<T> Next { get; set; }
    }
}
