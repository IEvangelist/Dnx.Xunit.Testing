using IEvangelist.CSharper.Calculator;
using System.Collections.Generic;
using Xunit;


namespace IEvangelist.CSharper.CalculatorTests
{
    public class Int32CalculatorTests
    {
        [Fact]
        public void SubstractTest()
        {
            // Arrange
            var calculator = new Int32Calculator();

            // Act
            var actual = calculator.Subtract(77, 100);

            // Assert
            Assert.Equal(-23, actual);
        }

        [Theory, InlineData(3, 3, 9), InlineData(2, 9, 18)]
        public void MultiplyTest(int leftOperand, int rightOperand, int expected)
        {
            // Arrange
            var calculator = new Int32Calculator();

            // Act
            var actual = calculator.Multiply(leftOperand, rightOperand);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory, ClassData(typeof(Int32CalculatorTestData))]
        public void AddTest(int leftOperand, int rightOperand, int expected)
        {
            // Arrange
            var calculator = new Int32Calculator();

            // Act
            var actual = calculator.Add(leftOperand, rightOperand);

            // Assert
            Assert.Equal(expected, actual);
        }

        public class Int32CalculatorTestData : ClassTestData
        {
            protected override List<object[]> TestData => new List<object[]>
            {
                new object[] { 1, 7, 8 },
                new object[] { 2, 2, 4 },
                new object[] { -33, -77, -110 },
                new object[] { 256, -512, -256 },
                new object[] { 0, 0, 0 },
            };
        }
    }
}