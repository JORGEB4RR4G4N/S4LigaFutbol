namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;

public class ClienteEquipo : IClienteEquipo
{
    private readonly HttpClient httpClient;

    public ClienteEquipo(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<EquiposDTO> ActualizarEquipo(Equipos equipos)
    {
        return await httpClient.PutAndReadJsonDtoAsync<EquiposDTO>("Equipo/ActualizarEquipo", equipos);
    }

    public async Task<EquiposDTO> Equipo(int IdEquipo)
    {
        return await httpClient.GetFromJsonAsync<EquiposDTO>($"Equipo/{IdEquipo}");
    }

    public async Task<EquiposDTO> InsertarEquipo(Equipos equipos)
    {
        return await httpClient.PostAndReadJsonDtoAsync<EquiposDTO>("Equipo/InsertarEquipos", equipos);
    }

    public async Task<List<EquiposDTO>> ListaEquipo(int? IdEquipo, int? IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<List<EquiposDTO>>($"Equipo/ListaEquipo/{IdEquipo}/{IdTorneo}");
    }
}
