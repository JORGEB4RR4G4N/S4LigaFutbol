using S4.LigaFutbol.Comunes.Operacion.OperacionDTO;

namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface ISancionDAC
{
    Task<int> InsertarSancion(Sanciones sanciones, int IdUsuario);
    Task<int> EliminarSancion(int IdSanciones, int IdUsuario);
    Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo);
    Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador);
}
