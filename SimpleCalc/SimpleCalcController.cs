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
                return "Number 1 is not integer";
            }

            if (!validator.IsValidInteger(number2))
            {
                return "Number 2 is not integer";
            }

            if (validator.IsDivideByZero(number1,number2,oper))
            {
                return "Divide By Zero";
            }

            int result;
            calculator.Number1 = Convert.ToInt32(number1);
            calculator.Number2 = Convert.ToInt32(number2);
            switch (oper)
            {
                case "Plus":
                    result = calculator.Add();
                    return result.ToString();
                case "Minus":
                    result = calculator.Subtract();
                    return result.ToString();
                case "Times":
                    result = calculator.Multiply();
                    return result.ToString();
                case "Divide":
                    result = calculator.Divide();
                    return result.ToString();
                default:
                    return "";
            }
        }
    }
}