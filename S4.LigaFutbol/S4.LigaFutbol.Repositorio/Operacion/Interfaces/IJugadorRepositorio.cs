namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IJugadorRepositorio
{
    Task<Jugadores> InsertarJugador(Jugadores jugadores, int IdUsuario);
    Task<Jugadores> ActualizarJugador(Jugadores jugadores, int IdUsuario);
    Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo);
    Task<Jugadores> Jugador(int IdJugador);
}
