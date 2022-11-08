namespace CallbackInterface
{
    public interface IEventosRefri
    {

        //Aca definimos la interfaz de callback
        //Podrian haber multiples sink que lo implementen
        void EReservasBajas(int kilos);
        void EDescongelado(int grados);
    }
}
