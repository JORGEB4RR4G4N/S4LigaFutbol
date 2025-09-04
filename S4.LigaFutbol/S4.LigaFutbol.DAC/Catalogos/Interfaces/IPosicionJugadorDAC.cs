namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface IPosicionJugadorDAC
{
    Task<int> InsertarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<bool> ActualizarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<List<PosicionesJugador>> ListaPosicionJugador();
    Task<PosicionesJugador> PosicionJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionJugador(int IdPosicionJuagdor, int IdUsuario);
}
