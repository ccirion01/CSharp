namespace I_Cloneable
{
    public class Auto : IAutomovil, ICloneable
    {
        public string Modelo { get; set; }
        public double Costo { get; set; }
        public double Tenencia { get; set; }

        public Auto(string modelo, double costo)
        {
            Modelo = modelo;
            Costo = costo;
        }

        public Auto()
        {
        }

        public void CalcularTenencia(double impuesto)
        {
            Tenencia = 5000.0 + Costo * impuesto;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Tu automovil {Modelo}");
            Console.WriteLine($"Costo {Costo}, con una tenencia de {Tenencia}");
            Console.WriteLine($"Total {Costo + Tenencia}");
            Console.WriteLine($"--------------");
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public Auto Clone()
        {
            return new Auto
            {
                Modelo = Modelo,
                Costo = Costo,
                Tenencia = Tenencia
            };
        }
    }
}
