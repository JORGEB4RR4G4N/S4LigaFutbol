namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface ISancionRepositorio
{
    Task<Sanciones> InsertarSancion(Sanciones sanciones, int IdUsuario);
    Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo);
    Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador);
}
