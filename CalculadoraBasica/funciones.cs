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
            string[] opciones =
            {
                "Sumar",
                "Restar",
                "Multiplicar",
                "Dividir",
                "Historial",
                "Salir"
            };

            int selector = 0;

            ConsoleKey tecla;

            do
            {
                Console.WriteLine("Bienvenido a la calculadora");

                Console.WriteLine("----------");
                Console.WriteLine();

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (selector == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($">{opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(opciones[i]);
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow)
                {
                    selector = (selector == 0) ? opciones.Length - 1 : selector - 1;
                }
                else if (tecla == ConsoleKey.DownArrow)
                {
                    selector = (selector == opciones.Length - 1) ? 0 : selector + 1;
                }
                Console.Clear();
            } while(tecla != ConsoleKey.Enter);

            return opciones[selector];
            
        }

        public void calculos(string opcion)
        {
            int num1;
            int num2;
            double resultado;
            Calculadora calculadora;
            Historial historial;
            List<Historial> listarHistorial;

            switch (opcion)
            {
                case "Sumar":
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
                case "Restar":
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
                case "Multiplicar":
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
                case "Dividir":
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
                case "Historial":
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
