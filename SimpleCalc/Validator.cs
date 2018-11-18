namespace SimpleCalc
{
    public class Validator
    {
        public bool IsValidNumber(string input)
        {
            return int.TryParse(input, out int n);
        }
    }
}