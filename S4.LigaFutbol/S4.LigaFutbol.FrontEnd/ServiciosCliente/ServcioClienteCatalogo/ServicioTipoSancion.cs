namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo;

public class ServicioTipoSancion : IServicioTipoSancion
{
    private readonly HttpClient httpClient;

    public ServicioTipoSancion(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion, int IdUsuario)
    {
        throw new NotImplementedException();
    }

    public Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion, int IdUsuario)
    {
        throw new NotImplementedException();
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
