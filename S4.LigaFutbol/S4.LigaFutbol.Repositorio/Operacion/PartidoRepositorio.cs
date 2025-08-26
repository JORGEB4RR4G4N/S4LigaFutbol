namespace S4.LigaFutbol.Repositorio.Operacion;

public class PartidoRepositorio : IPartidoRepositorio
{
    private readonly IPartidoDAC partidoDAC;
    public PartidoRepositorio(IPartidoDAC partidoDAC)
    {
        this.partidoDAC = partidoDAC;
    }

    public async Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo, int IdUsuario)
    {
        return await partidoDAC.ActualizarCancelarPartido(IdPartido, Motivo, IdUsuario);
    }

    public async Task<bool> ActualizarPartidoResultado(Partidos partidos, int IdUsuario)
    {
        return await partidoDAC.ActualizarPartidoResultado(partidos, IdUsuario);
    }

    public async Task<bool> InsertarPartidos(Partidos partidos, int IdUsuario)
    {
        bool partidosObjecto = false;

        var IdPartido = await partidoDAC.InsertarPartidos(partidos, IdUsuario);
        if (IdPartido > 0)
            partidosObjecto = true;


        return partidosObjecto;
    }

    public async Task<bool> InsertarProgramaPartidosAdicional(Partidos partidos, int IdUsuario)
    {
        bool partidosObjecto = false;

        var IdPartido = await partidoDAC.InsertarProgramaPartidosAdicional(partidos, IdUsuario);
        if (IdPartido > 0)
            partidosObjecto = true;


        return partidosObjecto;
    }

    public async Task<bool> InsertarProgramarPartidos(Partidos partidos, int IdUsuario)
    {
        bool partidosObjecto = false;

        var IdPartido = await partidoDAC.InsertarProgramarPartidos(partidos, IdUsuario);
        if (IdPartido > 0)
            partidosObjecto = true;


        return partidosObjecto;
    }

    public async Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario(int? IdTorneo, int? IdFase, int? IdEstadoPartido)
    {
        List<PartidosCalendarioDTO> ListapartidosCalendarioDTOs = new List<PartidosCalendarioDTO>();

        ListapartidosCalendarioDTOs = await partidoDAC.ListaPartidoCalendario(IdTorneo, IdFase, IdEstadoPartido);

        return ListapartidosCalendarioDTOs;
    }
}
