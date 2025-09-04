namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClienteTipoPartido : IClienteTipoPartido
{
    private readonly HttpClient httpClient;

    public ClienteTipoPartido(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido)
    {
        return await httpClient.PutAndReadJsonAsync("TipoPartido", tiposPartido);
    }

    public async Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido)
    {
        return await httpClient.PostAndReadJsonAsync("TipoPartido", tiposPartido);
    }

    public async Task<List<TiposPartido>> ListaTipoPartidos()
    {
        return await httpClient.GetFromJsonAsync<List<TiposPartido>>($"TipoPartido/ListaTipoPartidos");
    }

    public async Task<TiposPartido> TipoPartido(int IdTipoPartido)
    {
        return await httpClient.GetFromJsonAsync<TiposPartido>($"TipoPartido/{IdTipoPartido}");
    }
}
