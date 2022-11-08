namespace OperatorOverload
{
    public class EqualityOverload : IEquatable<EqualityOverload>
    {
        public int Value;

        public EqualityOverload(int value)
        {
            Value = value;
        }

        #region Operator overloads
        public static bool operator ==(EqualityOverload obj, EqualityOverload obj2)
        {
            return obj?.Value == obj2?.Value;
        }

        public static bool operator !=(EqualityOverload obj, EqualityOverload obj2)
        {
            return obj?.Value != obj2?.Value;
        }
        #endregion

        #region Equality overloads
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return Equals(obj as EqualityOverload);
        }

        public bool Equals(EqualityOverload other)
        {
            return other?.Value == Value;
        } 
        #endregion
    }
}
