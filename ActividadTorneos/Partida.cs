using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadTorneos
{
    public class Partida
    {
        private string nombreJuego;
        private int puntaje;
        private Jugador jugador;

        public Partida(string nombreJuego, int puntaje, Jugador jugador)
        {
            this.nombreJuego = nombreJuego;
            this.puntaje = puntaje;
            this.jugador = jugador;
        }

        public int GetPuntaje() => puntaje;
        public Jugador GetJugador() => jugador;

        public void MostrarPartida()
        {
            Console.WriteLine($"Juego: {nombreJuego}, Puntaje: {puntaje}");
            jugador.MostrarJugador();
        }
    }
}
