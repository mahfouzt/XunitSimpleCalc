using System;

namespace SimpleCalc
{
    public class SimpleCalcController
    {
        public string Calculate(string number1, string number2, string oper)
        {
            Validator validator = new Validator();
            Calculator calculator = new Calculator();
            

            if (!validator.IsValidInteger(number1))
            {
                return CalcConfig.Number1ErrorMsg;
            }

            if (!validator.IsValidInteger(number2))
            {
                return CalcConfig.Number2ErrorMsg;
            }

            if (validator.IsDivideByZero(number1,number2,oper))
            {
                return CalcConfig.DivideByZeroErrorMsg;
            }

            int result;
            calculator.Number1 = Convert.ToInt32(number1);
            calculator.Number2 = Convert.ToInt32(number2);
            switch (oper)
            {
                case CalcConfig.Plus:
                    result = calculator.Add();
                    return result.ToString();
                case CalcConfig.Minus:
                    result = calculator.Subtract();
                    return result.ToString();
                case CalcConfig.Times:
                    result = calculator.Multiply();
                    return result.ToString();
                case CalcConfig.Divide:
                    result = calculator.Divide();
                    return result.ToString();
                default:
                    return "";
            }
        }
    }
}