using CalculadoraBasica;

bool control = false;
int numero;



funciones fun = new funciones();

do
{
    string opcion = fun.menu();

    if( opcion != "Salir")
    {
        fun.calculos(opcion);
    }
    else
    {
        control = true;
    }

    Console.WriteLine("Presione Enter para continuar");
    Console.ReadLine();
    Console.Clear();

} while (control == false);

Console.WriteLine("Fin del programa");


