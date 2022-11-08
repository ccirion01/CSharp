namespace OperatorOverload
{
    public class NegationOverload
    {
        public int Value;

        public NegationOverload(int value)
        {
            Value = value;
        }

        public static bool operator !(NegationOverload obj)
        {
            return obj == null;
        }

        public static bool operator +(NegationOverload obj)
        {
            return obj != null;
        }
    }
}
