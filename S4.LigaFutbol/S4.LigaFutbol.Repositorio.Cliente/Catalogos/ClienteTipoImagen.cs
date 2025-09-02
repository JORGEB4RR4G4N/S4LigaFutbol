namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClienteTipoImagen : IClienteTipoImagen
{
    private readonly HttpClient httpClient;

    public ClienteTipoImagen(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen)
    {

        return await httpClient.PutAndReadJsonAsync("TiposImagen", tiposImagen);
    }

    public async Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen)
    {
        return await httpClient.PostAndReadJsonAsync($"TiposImagen", tiposImagen);
    }

    public async Task<List<TiposImagen>> ListaTipoImagen()
    {
        return await httpClient.GetFromJsonAsync<List<TiposImagen>>($"TipoSancion/ListaTipoSancion");
    }

    public async Task<TiposImagen> TipoImagen(int IdTipoImagen)
    {
        return await httpClient.GetFromJsonAsync<TiposImagen>($"TipoSancion/{IdTipoImagen}");
    }
}
