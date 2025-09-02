namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Extension;

public static class HttpClientesCatalogo
{
    public static IServiceCollection AddClientesCatalogos(this IServiceCollection services, Uri uriCatalogos)
    {
        services.AddHttpClient<IClienteTipoSancion, ClienteTipoSancion>((sp, client) => { client.BaseAddress = uriCatalogos; });
        return services;
    }
}

