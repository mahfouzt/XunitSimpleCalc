using System;

namespace SimpleCalc
{
    public class SimpleCalcController
    {
        public string Calculate(string number1, string number2, string oper)
        {
            Validator validator = new Validator();
            Calculator calculator = new Calculator();

            if (!validator.IsValidNumber(number1))
            {
                return "Number 1 is not integer";
            }

            if (!validator.IsValidNumber(number2))
            {
                return "Number 2 is not integer";
            }

            if (oper == "Divide" && Convert.ToInt32(number2) == 0)
            {
                return "Divide By Zero";
            }

            int result;
            switch (oper)
            {
                case "Plus":
                    result = calculator.Add(Convert.ToInt32(number1) , Convert.ToInt32(number2));
                    return result.ToString();
                case "Minus":
                    result = calculator.Subtract(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    return result.ToString();
                case "Times":
                    result = calculator.Multiply(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    return result.ToString();
                case "Divide":
                    result = calculator.Divide(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    return result.ToString();
                default:
                    return "";
            }
        }
    }
}