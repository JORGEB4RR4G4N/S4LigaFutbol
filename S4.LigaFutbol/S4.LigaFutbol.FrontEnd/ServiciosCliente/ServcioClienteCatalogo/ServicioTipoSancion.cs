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

    public Task<List<TiposSancion>> ListaTipoSancion()
    {
        throw new NotImplementedException();
    }

    public async Task<TiposSancion> TipoSancion(int IdTipoSancion)
    {
        return await httpClient.GetFromJsonAsync<TiposSancion>("API");
    }
}
