using CalculadoraBasica;

bool control = false;
int numero;

Console.WriteLine("Bienvenido a la calculadora");

Console.WriteLine("----------");
Console.WriteLine();

funciones fun = new funciones();

do
{
    string opcion = fun.menu();

    if (!int.TryParse(opcion, out numero)) Console.WriteLine("Entrada no valida, vuelva a intentar");

    if(numero == 6) control = true;

    if (numero != 0 && !control) fun.calculos(numero);

} while (control == false);

Console.WriteLine("Fin del programa");


