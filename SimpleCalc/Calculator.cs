namespace SimpleCalc
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add()
        {
            var result = Number1 + Number2;
            return result;
        }

        public int Subtract()
        {
            return Number1 - Number2;
        }

        public int Multiply()
        {
            return Number1 * Number2;
        }

        public int Divide()
        {
            return Number1 / Number2;
        }
    }
}