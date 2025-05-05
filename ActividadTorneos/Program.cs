namespace ActividadTorneos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Torneo torneo = new Torneo();

            Jugador j1 = new Jugador("Juan", 19, "Argentina");
            Jugador j2 = new Jugador("Luis", 18, "Chile");
            Jugador j3 = new Jugador("Carlos", 20, "Argentina");

            torneo.AgregarPartida(new Partida("Mortal Kombat 1", 120, j1));
            torneo.AgregarPartida(new Partida("FIFA 25", 150, j2));
            torneo.AgregarPartida(new Partida("CS:GO", 180, j3));

            torneo.MostrarListadoPartidas();
            torneo.ContarJugadoresPorPais("Argentina");
            torneo.MostrarMayorPuntaje();
        }
    }
}
