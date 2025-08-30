
namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Extenciones;


public static class HttpClientesCatalogo
{
    public static IServiceCollection AddClientesCatalogos(this IServiceCollection services, Uri uriCatalogos)
    {
        services.AddHttpClient<IServicioTipoSancion, ServicioTipoSancion>((sp, client) => { client.BaseAddress = uriCatalogos; });
        return services;
    }
}
