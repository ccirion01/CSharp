using I_Cloneable;

Auto auto = new Auto("March", 170000);

//Esto no esta clonandolo
Auto auto2 = auto;

auto.CalcularTenencia(0.10);
auto2.CalcularTenencia(0.10);

auto.MostrarInformacion();
auto2.MostrarInformacion();

Console.WriteLine($"--------------");

//Hacemos un cambio, creyendo que solo cambia auto 1
auto.Costo = 60000;

//Volvemos a mostrar, y vemos que cambiaron los 2
auto.MostrarInformacion();
auto2.MostrarInformacion();

Console.WriteLine($"--------------");

//Ahora si hacemos una clonacion
Auto auto3 = auto.Clone();

auto.MostrarInformacion();
auto3.MostrarInformacion();

Console.WriteLine($"--------------");

//Modificamos uno, el otro deberia seguir igual
auto.Costo = 250000;

//Verificamos
auto.MostrarInformacion();
auto3.MostrarInformacion();

Console.WriteLine($"--------------");