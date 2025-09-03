namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClientePartido
{
    Task<bool> ActualizarPartidoResultado(Partidos partidos);
    Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo);
    Task<bool> InsertarPartidos(Partidos partidos);
    Task<bool> InsertarProgramarPartidos(Partidos partidos);
    Task<bool> InsertarProgramaPartidosAdicional(Partidos partidos);
    Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario(int? IdTorneo, int? IdFase, int? IdEstadoPartido);
}
