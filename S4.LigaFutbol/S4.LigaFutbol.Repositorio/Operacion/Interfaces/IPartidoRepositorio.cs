namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IPartidoRepositorio
{
    Task<Partidos> ActualizarPartidoResultado(Partidos partidos, int IdUsuario);
    Task<Partidos> ActualizarCancelarPartido(int IdPartido, string Motivo, int IdUsuario);
    Task<Partidos> InsertarPartidos(Partidos partidos, int IdUsuario);
    Task<Partidos> InsertarProgramarPartidos(Partidos partidos, int IdUsuario);
    Task<Partidos> InsertarProgramaPartidosAdicional(Partidos partidos, int IdUsuario);
}
