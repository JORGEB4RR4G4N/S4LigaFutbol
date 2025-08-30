namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;

public interface IServicioPosicionJugador
{
    Task<PosicionesJugador> InsertarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<PosicionesJugador> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario);
    Task<List<PosicionesJugador>> ListaPosicionesJugador();
    Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor);
    Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor, int IdUsuario);
}
