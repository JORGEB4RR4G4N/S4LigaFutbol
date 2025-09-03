namespace S4.LigaFutbol.Repositorio.Cliente.Estadisticas.Interfaces;

public interface IClienteEstadisticas
{
    Task<List<GoleadoresDTO>> ListaTopGoleadores(int IdTorneo);
    Task<List<Jugadores>> ListaTopGoleadoresPorEquipo(int IdEquipo);

    Task<List<EnfrentamientoDTO>> ListaEnfrentamientosHistoricos(int IdEquipoLocal, int IdEquipoVisitante);

    Task<List<PosicionesDTO>> ListaPosicionesPorFase(int IdFase);
    Task<List<PosicionesDTO>> ListaPosicionesPorTorneo(int IdTorneo);

    Task<List<JugadoresSuspendidosDTOS>> ListaJugadoresSuspendidos(int? IdTorneo, int? IdFase, int? IdEquipo, bool Activos);
    Task<List<JugadoresSuspendidosPrevioPartidoDTO>> ListaJugadoresSuspendidosPrevioPartido(int IdPartido);
}
