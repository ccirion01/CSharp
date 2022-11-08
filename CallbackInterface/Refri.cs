using System.Collections;

namespace CallbackInterface
{
    public class Refri
    {
        private ArrayList listaSinks = new ArrayList();

        public int kilosAlimentos { get; set; } = 0;
        public int grados { get; set; } = 0;

        public Refri(int kilosAlimentos, int grados)
        {
            this.kilosAlimentos = kilosAlimentos;
            this.grados = grados;
        }

        public void AgregarSink(IEventosRefri sink)
        {
            if (sink != null)
                listaSinks.Add(sink);
        }

        public void EliminarSink(IEventosRefri sink)
        {
            if (listaSinks.Contains(sink))
                listaSinks.Remove(sink);
        }

        public void Trabajar(int consumo)
        {
            //Actualizamos los kg segun consumo
            kilosAlimentos -= consumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{kilosAlimentos} kilos, {grados} grados");

            //Llamamos a los observadores del evento solo si se cumple la condicion
            if (kilosAlimentos < 10)
            {
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }

            //Para cada evento que tengamos, hay una condicion para ver si disparar o no el evento
            if (grados >= 0)
            {
                foreach (IEventosRefri handler in listaSinks)
                {
                    handler.EDescongelado(grados);
                }
            }
        }
    }
}
