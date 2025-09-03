namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;
public class ClienteTorneo : IClienteTorneo
{
    private readonly HttpClient httpClient;

    public ClienteTorneo(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<Torneos> ActualizarTorneo(Torneos torneo)
    {
        return await httpClient.PutAndReadJsonAsync($"Torneo/ActualizarTorneo", torneo);
    }

    public async Task<Torneos> InsertarTorneo(Torneos torneo)
    {
        return await httpClient.PostAndReadJsonAsync($"Torneo/InsertarTorneo", torneo);
    }

    public async Task<List<Torneos>> ListaTorneo()
    {
        return await httpClient.GetFromJsonAsync<List<Torneos>>($"Partido/ListaTorneo");
    }

    public async Task<Torneos> Torneo(int IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<Torneos>($"Torneo/Torneo/{IdTorneo}");
    }
}
