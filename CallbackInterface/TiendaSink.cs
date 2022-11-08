namespace CallbackInterface
{
    public class TiendaSink : IEventosRefri
    {
        public void EReservasBajas(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("...Le enviaremos sus viveres");
            Console.WriteLine($"...Seran {kilos} kilos");
        }

        public void EDescongelado(int grados)
        {
            //Handler vacio
            //OJO: No es buena practica tener metodos de interfaces vacios, pero se hace asi por la forma en la que funcionan las interfaces de calback. Esto se resolvera con los delegados
        }
    }
}
