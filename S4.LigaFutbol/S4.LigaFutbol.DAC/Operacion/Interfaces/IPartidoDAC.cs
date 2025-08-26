namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface IPartidoDAC
{
    Task<bool> ActualizarPartidoResultado(Partidos partidos, int IdUsuario);
    Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo, int IdUsuario);
    Task<int> InsertarPartidos(Partidos partidos, int IdUsuario);
    Task<int> InsertarProgramarPartidos(Partidos partidos, int IdUsuario);
    Task<int> InsertarProgramaPartidosAdicional(Partidos partidos, int IdUsuario);
    Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario(int? IdTorneo, int? IdFase, int? IdEstadoPartido);

}
