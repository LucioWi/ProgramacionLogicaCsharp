using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadTorneos
{
    public class Torneo
    {
        private Partida[] historial;
        private int cantidad;

        public Torneo()
        {
            historial = new Partida[100];
            cantidad = 0;
        }

        public Torneo(int capacidad)
        {
            historial = new Partida[capacidad];
            cantidad = 0;
        }

        public void AgregarPartida(Partida partida)
        {
            if (cantidad < historial.Length)
            {
                historial[cantidad++] = partida;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más partidas.");
            }
        }

        public void MostrarListadoPartidas()
        {
            Console.WriteLine("\n--- Lista de Partidas ---");
            for (int i = 0; i < cantidad; i++)
            {
                historial[i].MostrarPartida();
                Console.WriteLine("-----------------------------");
            }
        }

        public void ContarJugadoresPorPais(string pais)
        {
            int contador = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (historial[i].GetJugador().GetPais().Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                }
            }
            Console.WriteLine($"Cantidad de jugadores de {pais}: {contador}");
        }

        public void MostrarMayorPuntaje()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay partidas registradas.");
                return;
            }

            Partida mayor = historial[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (historial[i].GetPuntaje() > mayor.GetPuntaje())
                {
                    mayor = historial[i];
                }
            }

            Console.WriteLine("\n--- Partida con Mayor Puntaje ---");
            mayor.MostrarPartida();
        }
    }
}
