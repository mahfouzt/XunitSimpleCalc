using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc;
using Xunit;


namespace Tests
{
    public class SimpleCalcControllerTest
    {
        [Theory]
        [InlineData("", "2", CalcConfig.Number1ErrorMsg)]
        [InlineData("0", "", CalcConfig.Number2ErrorMsg)]
        [InlineData("2", "0", CalcConfig.DivideByZeroErrorMsg)]
        public void Calculate_Errors(string value1, string value2, string expected)
        {
            //arrange
            var simpleCalcController = new SimpleCalcController();
            

            //act
            var result = simpleCalcController.Calculate(value1, value2, CalcConfig.Divide);

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("0","12","0")]
        [InlineData("0","-12","0")]
        [InlineData("12","12","1")]
        [InlineData("12","-12","-1")]
        [InlineData("-12","12","-1")]
        public void Calculate_Divide(string value1, string value2, string expected)
        {
            //arrange
            var simpleCalcController = new SimpleCalcController();


            //act
            var result = simpleCalcController.Calculate(value1, value2, CalcConfig.Divide);

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("0","0","0")]
        [InlineData("0","12","12")]
        [InlineData("12","0","12")]
        [InlineData("0","-12","-12")]
        [InlineData("-12","0","-12")]
        [InlineData("12","12","24")]
        [InlineData("12","-12","0")]
        [InlineData("-12","12","0")]
        public void Calculate_Add(string value1, string value2, string expected)
        {
            //arrange
            var simpleCalcController = new SimpleCalcController();


            //act
            var result = simpleCalcController.Calculate(value1, value2, CalcConfig.Plus);

            //assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("0","0","0")]
        [InlineData("0","12","-12")]
        [InlineData("12","0","12")]
        [InlineData("0","-12","12")]
        [InlineData("-12","0","-12")]
        [InlineData("12","12","0")]
        [InlineData("12","-12","24")]
        [InlineData("-12","12","-24")]
        public void Calculate_Subtract(string value1, string value2, string expected)
        {
            //arrange
            var simpleCalcController = new SimpleCalcController();


            //act
            var result = simpleCalcController.Calculate(value1, value2, CalcConfig.Minus);

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("0","0","0")]
        [InlineData("0","12","0")]
        [InlineData("12","0","0")]
        [InlineData("0","-12","0")]
        [InlineData("-12","0","0")]
        [InlineData("12","12","144")]
        [InlineData("12","-12","-144")]
        [InlineData("-12","12","-144")]
        public void Calculate_Multiply(string value1, string value2, string expected)
        {
            //arrange
            var simpleCalcController = new SimpleCalcController();


            //act
            var result = simpleCalcController.Calculate(value1, value2, CalcConfig.Times);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
