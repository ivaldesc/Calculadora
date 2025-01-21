using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    internal class Calculadora
    {
        private int num1 { get; set; }
        private int num2 { get; set; }

        public Calculadora(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int sumar()
        {
            return num1 + num2;
        }

        public int restar()
        {
            return num1 - num2;
        }

        public int multiplicar()
        {
            return num1 * num2;
        }

        public double dividir()
        {
            return (double)num1 / num2;
        }
    }
}
