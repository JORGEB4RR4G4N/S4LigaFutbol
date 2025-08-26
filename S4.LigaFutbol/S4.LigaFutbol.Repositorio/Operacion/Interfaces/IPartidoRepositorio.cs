namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IPartidoRepositorio
{
    Task<bool> ActualizarPartidoResultado(Partidos partidos, int IdUsuario);
    Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo, int IdUsuario);
    Task<bool> InsertarPartidos(Partidos partidos, int IdUsuario);
    Task<bool> InsertarProgramarPartidos(Partidos partidos, int IdUsuario);
    Task<bool> InsertarProgramaPartidosAdicional(Partidos partidos, int IdUsuario);
    Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario(int? IdTorneo, int? IdFase, int? IdEstadoPartido);
}
