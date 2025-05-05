using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadTorneos
{
    public class Jugador
    {
        private string nombre;
        private int edad;
        private string pais;

        public Jugador(string nombre, int edad, string pais)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.pais = pais;
        }

        public string GetNombre() => nombre;
        public string GetPais() => pais;

        public void MostrarJugador()
        {
            Console.WriteLine($"Jugador: {nombre}, Edad: {edad}, País: {pais}");
        }
    }
}
