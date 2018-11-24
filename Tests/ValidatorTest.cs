using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc;
using Xunit;


namespace Tests
{
    public class ValidatorTest
    {
        [Fact]
        public void IsValidNumber_True_PositiveInt()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("2548");

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidNumber_True_NegativeInt()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("-2548");

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidNumber_True_Zero()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("0");

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidNumber_False_String()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("Test");

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidNumber_False_StringAndNumber()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("123Test123");

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidNumber_False_Space()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger(" ");

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidNumber_False_Null()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("");

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidNumber_False_Float()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsValidInteger("1.2");

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsDivideByZero_True_SecondParamZero()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsDivideByZero("1", "0", "Divide");

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsDivideByZero_False_SecondParamNonZero()
        {
            //arrange
            var v = new Validator();

            //act
            var result = v.IsDivideByZero("1", "1", "Divide");

            //assert
            Assert.False(result);
        }
    }
}
