namespace I_Comparable
{
    public class Car_Reference
    {
        public string Plate { get; set; }

        public static bool operator ==(Car_Reference c1, Car_Reference c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Car_Reference c1, Car_Reference c2)
        {
            return !(c1 == c2);
        }
    }
}
