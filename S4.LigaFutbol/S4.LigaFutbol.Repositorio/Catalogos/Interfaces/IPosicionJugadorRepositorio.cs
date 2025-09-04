namespace S4.LigaFutbol.Repositorio.Catalogos.Interfaces;
public interface IPosicionJugadorRepositorio
{
    Task<PosicionesJugador> InsertarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<PosicionesJugador> ActualizarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<List<PosicionesJugador>> ListaPosicionJugador();
    Task<PosicionesJugador> PosicionJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionJugador(int IdPosicionJuagdor, int IdUsuario);
}
