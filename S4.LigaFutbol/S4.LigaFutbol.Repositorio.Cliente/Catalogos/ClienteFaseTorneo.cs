namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClienteFaseTorneo : IClienteFaseTorneo
{
    private readonly HttpClient httpClient;

    public ClienteFaseTorneo(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<FasesTorneo> ActualizarFaseTorneo(FasesTorneo fasesTorneo)
    {
        return await httpClient.PutAndReadJsonAsync("FasesTorneo", fasesTorneo);
    }

    public async Task<FasesTorneoDTO> FaseTorneo(int IdFase)
    {
        return await httpClient.GetFromJsonAsync<FasesTorneoDTO>($"FasesTorneo/{IdFase}");
    }

    public async Task<FasesTorneo> InsertarFaseTorneo(FasesTorneo fasesTorneo)
    {
        return await httpClient.PostAndReadJsonAsync("FasesTorneo", fasesTorneo);
    }

    public async Task<List<FasesTorneoDTO>> ListaFasesTorneo(int? IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<List<FasesTorneoDTO>>($"FasesTorneo/ListaFasesTorneo/{IdTorneo}");
    }
    public async Task<List<FasesTorneoDTO>> ListaFasesTorneo()
    {
        return await httpClient.GetFromJsonAsync<List<FasesTorneoDTO>>($"FasesTorneo/ListaFasesTorneo");
    }
}
