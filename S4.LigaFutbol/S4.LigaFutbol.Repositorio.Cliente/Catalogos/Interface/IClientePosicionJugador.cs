namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;

public interface IClientePosicionJugador
{
    Task<PosicionesJugador> InsertarPosicionJugador(PosicionesJugador posicionesJugador);
    Task<PosicionesJugador> ActualizarPosicionJugador(PosicionesJugador posicionesJugador);
    Task<List<PosicionesJugador>> ListaPosicionJugador();
    Task<PosicionesJugador> PosicionJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionJugador(int IdPosicionJuagdor);
}
