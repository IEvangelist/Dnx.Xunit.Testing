namespace IEvangelist.CSharper.Calculator
{
    public class DecimalCalculator : ICalculator<decimal>
    {
        public decimal Add(decimal leftOperand, decimal rightOperand) => leftOperand + rightOperand;
        public decimal Divide(decimal leftOperand, decimal rightOperand) => leftOperand / rightOperand;
        public decimal Multiply(decimal leftOperand, decimal rightOperand) => leftOperand * rightOperand;
        public decimal Subtract(decimal leftOperand, decimal rightOperand) => leftOperand - rightOperand;
    }
}