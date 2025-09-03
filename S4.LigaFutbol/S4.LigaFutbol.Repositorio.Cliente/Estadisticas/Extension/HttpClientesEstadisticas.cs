namespace S4.LigaFutbol.Repositorio.Cliente.Estadisticas.Extension;

public static class HttpClientesEstadisticas
{
    public static IServiceCollection AddClientesEstadistica(this IServiceCollection services, Uri uriCatalogos)
    {
        services.AddHttpClient<IClienteEstadisticas, ClienteEstadisticas>((sp, client) => { client.BaseAddress = uriCatalogos; });

        return services;
    }
}
