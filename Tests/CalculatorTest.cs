using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc;
using Xunit;


namespace Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 12, 12)]
        [InlineData(12, 0, 12)]
        [InlineData(0, -12, -12)]
        [InlineData(-12, 0, -12)]
        [InlineData(12, 12, 24)]
        [InlineData(12, -12, 0)]
        [InlineData(-12, 12, 0)]
        public void Add(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();
            calculator.Number1 = value1;
            calculator.Number2 = value2;

            //act
            var result = calculator.Add();

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 12, -12)]
        [InlineData(12, 0, 12)]
        [InlineData(0, -12, 12)]
        [InlineData(-12, 0, -12)]
        [InlineData(12, 12, 0)]
        [InlineData(12, -12, 24)]
        [InlineData(-12, 12, -24)]
        public void Subtract(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();
            calculator.Number1 = value1;
            calculator.Number2 = value2;

            //act
            var result = calculator.Subtract();

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 12, 0)]
        [InlineData(12, 0, 0)]
        [InlineData(0, -12, 0)]
        [InlineData(-12, 0, 0)]
        [InlineData(12, 12, 144)]
        [InlineData(12, -12, -144)]
        [InlineData(-12, 12, -144)]
        public void Multiply(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();
            calculator.Number1 = value1;
            calculator.Number2 = value2;

            //act
            var result = calculator.Multiply();

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 12, 0)]
        [InlineData(0, -12, 0)]
        [InlineData(12, 12, 1)]
        [InlineData(12, -12, -1)]
        [InlineData(-12, 12, -1)]
        public void Divide(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();
            calculator.Number1 = value1;
            calculator.Number2 = value2;

            //act
            var result = calculator.Divide();

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, null)]
        [InlineData(12, 0, null)]
        [InlineData(-12, 0, null)]
        public void Divide_Exception_SecondParamZero(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();
            calculator.Number1 = value1;
            calculator.Number2 = value2;

            //assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }
    }
}
