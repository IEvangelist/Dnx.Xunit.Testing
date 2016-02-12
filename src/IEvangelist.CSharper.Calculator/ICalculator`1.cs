namespace IEvangelist.CSharper.Calculator
{
    public interface ICalculator<T>
    {
        T Add(T leftOperand, T rightOperand);
        T Subtract(T leftOperand, T rightOperand);
        T Multiply(T leftOperand, T rightOperand);
        T Divide(T leftOperand, T rightOperand);
    }
}