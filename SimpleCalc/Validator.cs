using System;

namespace SimpleCalc
{
    public class Validator
    {
        public bool IsValidInteger(string input)
        {
            return int.TryParse(input, out int n);
        }

        public bool IsDivideByZero(string input1, string input2, string oper)
        {
            return oper == "Divide" && Convert.ToInt32(input2) == 0;
        }
    }
}