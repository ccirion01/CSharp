namespace OperatorOverload
{
    public class IncrementOverload
    {
        public int Value;

        public IncrementOverload(int value)
        {
            Value = value;
        }

        public static IncrementOverload operator ++(IncrementOverload obj)
        {
            return new IncrementOverload(++obj.Value);
        }

        public void Display()
        {
            Console.WriteLine("{0}", Value);
        }
    }
}
