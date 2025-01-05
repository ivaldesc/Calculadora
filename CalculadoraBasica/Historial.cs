using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    public class Historial
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }
        public string operacion { get; set; } = "";
        public double resultado { get; set; }
        private string filePath = "historial.json";

        public Historial(int num1,int num2,string operacion,double resultado)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.operacion = operacion;
            this.resultado = resultado;
        }

        public Historial()
        {

        }

        public void guardar(Historial historial)
        {
            List<Historial> lista = listar();
            lista.Add(historial);

            string jsonString = JsonSerializer.Serialize(lista);

            File.WriteAllText(this.filePath, jsonString);
        }

        public List<Historial> listar()
        {
            List<Historial> listaHistorial;

            if (File.Exists(this.filePath))
            {
                string contenidoActual = File.ReadAllText(this.filePath);
                listaHistorial = JsonSerializer.Deserialize<List<Historial>>(contenidoActual) ?? new List<Historial>();
            }
            else
            {
                listaHistorial= new List<Historial>();
            }

            return listaHistorial;
        }
    }
}
