namespace S4.LigaFutbol.DAC.Operacion.Interfaces;
public interface IJugadorDAC
{
    Task<int> InsertarJugador(Jugadores jugadores, int IdUsuario);
    Task<bool> ActualizarJugador(Jugadores jugadores, int IdUsuario);
    Task<List<Jugadores>> ListaJugadorPorEquipo(int IdEquipo);
    Task<List<Jugadores>> ListaTopGoleadoresPorEquipo(int IdTorneo);
    Task<Jugadores> Jugador(int IdJugador);
}
