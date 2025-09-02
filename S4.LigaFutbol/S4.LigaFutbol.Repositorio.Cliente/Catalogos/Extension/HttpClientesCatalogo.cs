namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Extension;

public static class HttpClientesCatalogo
{
    public static IServiceCollection AddClientesCatalogos(this IServiceCollection services, Uri uriCatalogos)
    {
        services.AddHttpClient<IClienteFaseTorneo, ClienteFaseTorneo>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClientePosicionJugador, ClientePosicionJugador>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteTipoImagen, ClienteTipoImagen>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteTipoPartido, ClienteTipoPartido>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteTipoSancion, ClienteTipoSancion>((sp, client) => { client.BaseAddress = uriCatalogos; });
        return services;
    }
}

