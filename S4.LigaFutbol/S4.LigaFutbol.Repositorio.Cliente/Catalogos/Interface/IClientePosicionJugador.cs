namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;

public interface IClientePosicionJugador
{
    Task<PosicionesJugador> InsertarPosicionesJugador(PosicionesJugador posicionesJugador);
    Task<PosicionesJugador> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador);
    Task<List<PosicionesJugador>> ListaPosicionesJugador();
    Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor);
}
