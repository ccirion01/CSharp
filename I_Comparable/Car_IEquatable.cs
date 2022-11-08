namespace I_Comparable
{
    public class Car_IEquatable : IEquatable<Car_IEquatable>
    {
        public string Plate { get; set; }

        public bool Equals(Car_IEquatable? other)
        {
            return other != null && other.Plate == Plate;
        }
    }
}
