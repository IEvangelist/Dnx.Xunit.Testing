namespace IEvangelist.CSharper.Calculator
{
    public class Int32Calculator : ICalculator<int>
    {
        public int Add(int leftOperand, int rightOperand) => leftOperand + rightOperand;
        public int Divide(int leftOperand, int rightOperand) => leftOperand / rightOperand;
        public int Multiply(int leftOperand, int rightOperand) => leftOperand * rightOperand;
        public int Subtract(int leftOperand, int rightOperand) => leftOperand - rightOperand;
    }
}