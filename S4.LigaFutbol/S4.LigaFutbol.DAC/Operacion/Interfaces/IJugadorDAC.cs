namespace S4.LigaFutbol.DAC.Operacion.Interfaces;
public interface IJugadorDAC
{
    Task<int> InsertarJugador(Jugadores jugadores, int IdUsuario);
    Task<bool> ActualizarJugador(Jugadores jugadores, int IdUsuario);
    Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo);
    Task<Jugadores> Jugador(int IdJugador);
}
