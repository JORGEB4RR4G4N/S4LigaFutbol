namespace S4.LigaFutbol.Repositorio.Estadisticas;

public class EstadisticasRepositorio : IEstadisticasRepositorio
{
    private readonly IEstadisticasDAC estadisticasDAC;
    public EstadisticasRepositorio(IEstadisticasDAC estadisticasDAC)
    {
        this.estadisticasDAC = estadisticasDAC;
    }

    public async Task<List<EnfrentamientoDTO>> ListaEnfrentamientosHistoricos(int IdEquipoLocal, int IdEquipoVisitante)
    {
        List<EnfrentamientoDTO> enfrentamientoDTOs = new List<EnfrentamientoDTO>();

        enfrentamientoDTOs = await estadisticasDAC.ListaEnfrentamientosHistoricos(IdEquipoLocal, IdEquipoVisitante);

        return enfrentamientoDTOs;

    }

    public async Task<List<JugadoresSuspendidosDTOS>> ListaJugadoresSuspendidos(int? IdTorneo, int? IdFase, int? IdEquipo, bool Activos)
    {
        List<JugadoresSuspendidosDTOS> jugadoresSuspendidosDTOs = new List<JugadoresSuspendidosDTOS>();

        jugadoresSuspendidosDTOs = await estadisticasDAC.ListaJugadoresSuspendidos(IdTorneo, IdFase, IdEquipo, Activos);

        return jugadoresSuspendidosDTOs;
    }

    public async Task<List<JugadoresSuspendidosPrevioPartidoDTO>> ListaJugadoresSuspendidosPrevioPartido(int IdPartido)
    {
        List<JugadoresSuspendidosPrevioPartidoDTO> jugadoresSuspendidosPrevioPartidoDTOs = new List<JugadoresSuspendidosPrevioPartidoDTO>();

        jugadoresSuspendidosPrevioPartidoDTOs = await estadisticasDAC.ListaJugadoresSuspendidosPrevioPartido(IdPartido);

        return jugadoresSuspendidosPrevioPartidoDTOs;
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorFase(int IdFase)
    {
        List<PosicionesDTO> posicionesDTOs = new List<PosicionesDTO>();

        posicionesDTOs = await estadisticasDAC.ListaPosicionesPorFase(IdFase);

        return posicionesDTOs;
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorTorneo(int IdTorneo)
    {
        List<PosicionesDTO> posicionesDTOs = new List<PosicionesDTO>();

        posicionesDTOs = await estadisticasDAC.ListaPosicionesPorTorneo(IdTorneo);

        return posicionesDTOs;
    }

    public async Task<List<GoleadoresDTO>> ListaTopGoleadores(int IdTorneo)
    {
        List<GoleadoresDTO> goleadoresDTOs = new List<GoleadoresDTO>();

        goleadoresDTOs = await estadisticasDAC.ListaTopGoleadores(IdTorneo);

        return goleadoresDTOs;
    }

    public async Task<List<Jugadores>> ListaTopGoleadoresPorEquipo(int IdEquipo)
    {
        List<Jugadores> goleadoresDTOs = new List<Jugadores>();

        goleadoresDTOs = await estadisticasDAC.ListaTopGoleadoresPorEquipo(IdEquipo);

        return goleadoresDTOs;
    }
}
