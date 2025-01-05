using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    internal class funciones
    {
        public funciones() { }

        public string menu()
        {
            Console.WriteLine("Opciones de calculadora: ");
            Console.WriteLine();
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("5.- Historial");
            Console.WriteLine("6.- Salir");

            Console.WriteLine();
            Console.WriteLine("Elija el numero de la opción: ");
            string opcion = Console.ReadLine();

            return opcion;
        }

        public void calculos(int opcion)
        {
            int num1;
            int num2;
            double resultado;
            Calculadora calculadora;
            Historial historial;
            List<Historial> listarHistorial;

            switch (opcion)
            {
                case 1:
                    num1 = entrada(1);
                    num2 = entrada(2);

                    calculadora = new Calculadora(num1, num2);

                    resultado = calculadora.sumar();

                    Console.Clear();

                    Console.WriteLine($"El resultado de la Suma {resultado}");

                    historial = new Historial(num1,num2,"+",resultado);
                    historial.guardar(historial);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    break;
                case 2:
                    num1 = entrada(1);
                    num2 = entrada(2);

                    calculadora = new Calculadora(num1, num2);
                    resultado = calculadora.restar();

                    Console.Clear();

                    Console.WriteLine($"El resultado de la Resta {resultado}");

                    historial = new Historial(num1, num2, "-", resultado);
                    historial.guardar(historial);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    break;
                case 3:
                    num1 = entrada(1);
                    num2 = entrada(2);

                    calculadora = new Calculadora(num1, num2);
                    resultado = calculadora.multiplicar();

                    Console.Clear();

                    Console.WriteLine($"El resultado de la Multiplicación {resultado}");

                    historial = new Historial(num1, num2, "*", resultado);
                    historial.guardar(historial);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                case 4:
                    num1 = entrada(1);
                    num2 = entrada(2);

                    if (num2 == 0)
                    {
                        Console.WriteLine("Imposible dividir por 0");
                        break;
                    }

                    calculadora = new Calculadora(num1, num2);

                    resultado = calculadora.dividir();
                    Console.Clear();
                    Console.WriteLine($"El resultado de la Dividir {resultado}");

                    historial = new Historial(num1, num2, "/", resultado);
                    historial.guardar(historial);
                    break;
                case 5:
                    Console.Clear();
                    historial = new Historial();
                    listarHistorial = historial.listar();

                    Console.WriteLine("Historial de operaciones:");
                    Console.WriteLine();

                    foreach (var item in listarHistorial)
                    {
                        Console.WriteLine($"{item.num1} {item.operacion} {item.num2} = {item.resultado}");
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Valor no valido.");
                    break;
            }
        }

        public int entrada(int mensaje)
        {
            string numero;
            int valor;

            while (true)
            {
                Console.WriteLine($"Ingrese el valor para el num {mensaje}");
                numero = Console.ReadLine();

                if (int.TryParse(numero, out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor ingresado no valido, vuelva a intentar");
                }
            }
            
        }
    }
}
