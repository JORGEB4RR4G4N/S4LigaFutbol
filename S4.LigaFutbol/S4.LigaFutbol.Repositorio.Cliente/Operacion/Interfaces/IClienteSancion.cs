namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClienteSancion
{
    Task<bool> InsertarSancion(Sanciones sanciones);
    Task<bool> ElimnarSancion(int IdSancion);
    Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo);
    Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador);
}
