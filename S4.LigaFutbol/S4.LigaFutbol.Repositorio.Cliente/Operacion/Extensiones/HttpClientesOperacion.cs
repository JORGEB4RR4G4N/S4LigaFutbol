namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Extensiones;

public static class HttpClientesOperacion
{
    public static IServiceCollection AddClientesOperacion(this IServiceCollection services, Uri uriCatalogos)
    {
        services.AddHttpClient<IClienteEquipo, ClienteEquipo>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteGol, ClienteGol>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteJugador, ClienteJugador>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClientePartido, ClientePartido>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteSancion, ClienteSancion>((sp, client) => { client.BaseAddress = uriCatalogos; });
        services.AddHttpClient<IClienteTorneo, ClienteTorneo>((sp, client) => { client.BaseAddress = uriCatalogos; });
        return services;
    }
}
