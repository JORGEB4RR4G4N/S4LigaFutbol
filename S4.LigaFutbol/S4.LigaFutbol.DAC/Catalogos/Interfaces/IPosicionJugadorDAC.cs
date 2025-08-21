namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface IPosicionJugadorDAC
{
    Task<int> InsertarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<bool> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<List<PosicionesJugador>> ListaPosicionesJugador();
    Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor, int IdUsuario);
}
