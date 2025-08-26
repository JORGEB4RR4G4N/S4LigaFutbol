namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;

public static class TipoSancionExtension
{

    public static IServiceCollection addTipoSancionExtension(this IServiceCollection services)
    {
        services.AddTransient<ITipoSancionRepositorio, TipoSancionRepositorio>();
        services.AddTransient<ITipoSancionDAC, TipoSancionDAC>();
        return services;
    }

}
