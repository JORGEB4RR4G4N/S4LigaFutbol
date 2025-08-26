namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;

public static class TipoImagenExtension
{
    public static IServiceCollection addTipoImagenExtension(this IServiceCollection services)
    {
        services.AddTransient<ITipoImagenRepositorio, TipoImagenRepositorio>();
        services.AddTransient<ITipoImagenDAC, TipoImagenDAC>();
        return services;
    }
}
