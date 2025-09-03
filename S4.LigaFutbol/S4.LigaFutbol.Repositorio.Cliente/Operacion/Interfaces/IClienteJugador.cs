namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClienteJugador
{
    Task<Jugadores> InsertarJugador(Jugadores jugadores);
    Task<Jugadores> ActualizarJugador(Jugadores jugadores);
    Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo);
    Task<Jugadores> Jugador(int IdJugador);
}
