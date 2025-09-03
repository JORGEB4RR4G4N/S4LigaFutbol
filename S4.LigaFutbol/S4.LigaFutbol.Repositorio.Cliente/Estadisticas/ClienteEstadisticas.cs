namespace S4.LigaFutbol.Repositorio.Cliente.Estadisticas;

public class ClienteEstadisticas : IClienteEstadisticas
{
    private readonly HttpClient httpClient;

    public ClienteEstadisticas(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<EnfrentamientoDTO>> ListaEnfrentamientosHistoricos(int IdEquipoLocal, int IdEquipoVisitante)
    {
        return await httpClient.GetFromJsonAsync<List<EnfrentamientoDTO>>($"ListaEnfrentamientosHistoricos/{IdEquipoLocal}/{IdEquipoVisitante}");
    }

    public async Task<List<JugadoresSuspendidosDTOS>> ListaJugadoresSuspendidos(int? IdTorneo, int? IdFase, int? IdEquipo, bool Activos)
    {
        return await httpClient.GetFromJsonAsync<List<JugadoresSuspendidosDTOS>>($"ListaJugadoresSuspendidos/{IdTorneo}/{IdFase}/{IdEquipo}/{Activos}");
    }

    public async Task<List<JugadoresSuspendidosPrevioPartidoDTO>> ListaJugadoresSuspendidosPrevioPartido(int IdPartido)
    {
        return await httpClient.GetFromJsonAsync<List<JugadoresSuspendidosPrevioPartidoDTO>>($"ListaJugadoresSuspendidosPrevioPartido/{IdPartido}");
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorFase(int IdFase)
    {
        return await httpClient.GetFromJsonAsync<List<PosicionesDTO>>($"ListaPosicionesPorFase/{IdFase}");
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorTorneo(int IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<List<PosicionesDTO>>($"ListaPosicionesPorTorneo/{IdTorneo}");
    }

    public async Task<List<GoleadoresDTO>> ListaTopGoleadores(int IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<List<GoleadoresDTO>>($"ListaTopGoleadores/{IdTorneo}");
    }

    public async Task<List<Jugadores>> ListaTopGoleadoresPorEquipo(int IdEquipo)
    {
        return await httpClient.GetFromJsonAsync<List<Jugadores>>($"ListaTopGoleadores/{IdEquipo}");
    }
}
