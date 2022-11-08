namespace I_Comparable
{
    public class Car_IComparable : IComparable<Car_IComparable>
    {
        public string Plate { get; set; }
        public DateTime Year { get; set; }

        public int CompareTo(Car_IComparable other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Plate.CompareTo(other.Plate);
            //Aca podemos anidar las comparaciones necesarias
            //Si plate es igual, compara por fecha, etc
        }
    }
}
