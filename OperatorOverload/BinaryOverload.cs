namespace OperatorOverload
{
    class Calculator
    {
        public int Number = 0;
        public Calculator() { }
        public Calculator(int n)
        {
            Number = n;
        }

        public static Calculator operator +(Calculator calc1, Calculator calc2)
        {
            Calculator calc3 = new Calculator(0);
            calc3.Number = calc2.Number + calc1.Number;
            return calc3;
        }

        // function to display result
        public void Display()
        {
            Console.WriteLine("{0}", Number);
        }
    }   
}