namespace I_Comparable
{
    public class Car_IComparer : IComparer<Car_IComparer>
    {
        public string Plate { get; set; }
        public DateTime Year { get; set; }

        public int Compare(Car_IComparer x, Car_IComparer y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;

            int plateComparison = x.Plate.CompareTo(y.Plate);
            if (plateComparison != 0) return plateComparison;
            return x.Year.CompareTo(y.Year);
            //Aca tambien podemos hacer las anidaciones necesarias
        }
    }
}
