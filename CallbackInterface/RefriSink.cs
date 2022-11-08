namespace CallbackInterface
{
    public class RefriSink : IEventosRefri
    {
        public bool Paro { get; set; } = false;

        //Aca colocamos los handlers de los eventos definidos en la interfaz
        //Puede llevar a cabo otro trabajo y tambien tener el handler, o unicamente encargarse de ser el handler
        //(El segundo approach me gusta mas por el SRP)
        public void EReservasBajas(int kilos)
        {
            //Esto se ejecuta cuando se dispare el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...Reservas bajas de alimentos");
            Console.WriteLine($"...Quedan {kilos} kilos");
        }

        public void EDescongelado(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("...El refri se descongela!");

            if (grados > 0)
                Paro = true;
        }
    }
}
