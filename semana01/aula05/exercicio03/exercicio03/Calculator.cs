namespace exercicio03
{
    internal class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public Calculator(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public double Sum()
        {
            return FirstNumber + SecondNumber;
        }

        public double Subtraction()
        {
            return FirstNumber - SecondNumber;
        }

        public double Multiplication()
        {
            return FirstNumber * SecondNumber;
        }

        public double Division()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
