namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;

public class ClientePartido : IClientePartido
{
    private readonly HttpClient httpClient;

    public ClientePartido(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo)
    {
        return await httpClient.PutAndReadJsonDtoAsync<bool>($"Partido/ActualizarCancelarPartido", new { IdPartido = IdPartido, Motivo = Motivo });
    }

    public async Task<bool> ActualizarPartidoResultado(Partidos partidos)
    {
        return await httpClient.PutAndReadJsonDtoAsync<bool>($"Partido/ActualizarPartidoResultado", partidos);
    }

    public async Task<bool> InsertarPartidos(Partidos partidos)
    {
        return await httpClient.PostAndReadJsonDtoAsync<bool>("Partido/InsertarPartidos", partidos);
    }

    public async Task<bool> InsertarProgramaPartidosAdicional(Partidos partidos)
    {
        return await httpClient.PostAndReadJsonDtoAsync<bool>("Partido/InsertarProgramaPartidosAdicional", partidos);
    }

    public async Task<bool> InsertarProgramarPartidos(Partidos partidos)
    {
        return await httpClient.PostAndReadJsonDtoAsync<bool>("Partido/InsertarProgramarPartidos", partidos);
    }

    public async Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario(int? IdTorneo, int? IdFase, int? IdEstadoPartido)
    {
        return await httpClient.GetFromJsonAsync<List<PartidosCalendarioDTO>>($"Partido/ListaPartidoCalendario/{IdTorneo}/{IdFase}/{IdEstadoPartido}");
    }
}
