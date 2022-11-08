using CallbackInterface;

Refri refri = new Refri(500, -20);

RefriSink sink = new RefriSink();
TiendaSink sink2 = new TiendaSink();
refri.AgregarSink(sink);
refri.AgregarSink(sink2);

Random rand = new Random();

while (refri.kilosAlimentos > 0 && !sink.Paro)
{
    refri.Trabajar(rand.Next(1,5));
}