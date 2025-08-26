namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;

public static class TipoPartidoExtension
{
    public static IServiceCollection addTipoPartidoExtension(this IServiceCollection services)
    {
        services.AddTransient<ITipoPartidoRepositorio, TipoPartidoRepositorio>();
        services.AddTransient<ITipoPartidoDAC, TipoPartidoDAC>();
        return services;
    }
}
