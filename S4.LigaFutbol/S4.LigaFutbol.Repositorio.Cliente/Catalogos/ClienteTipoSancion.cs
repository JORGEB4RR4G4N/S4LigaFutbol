namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClienteTipoSancion : IClienteTipoSancion
{
    private readonly HttpClient httpClient;

    public ClienteTipoSancion(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion)
    {
        return await httpClient.PutAndReadJsonAsync("TipoSancion", tiposSancion);
    }

    public async Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion)
    {
        return await httpClient.PostAndReadJsonAsync($"TipoSancion", tiposSancion);
    }

    public async Task<List<TiposSancion>> ListaTipoSancion()
    {
        return await httpClient.GetFromJsonAsync<List<TiposSancion>>($"TipoSancion/ListaTipoSancion");

    }

    public async Task<TiposSancion> TipoSancion(int IdTipoSancion)
    {
        return await httpClient.GetFromJsonAsync<TiposSancion>($"TipoSancion/{IdTipoSancion}");
    }
}
