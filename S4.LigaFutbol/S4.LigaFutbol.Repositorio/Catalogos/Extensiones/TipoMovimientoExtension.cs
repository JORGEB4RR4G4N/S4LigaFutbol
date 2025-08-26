namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;

public static class TipoMovimientoExtension
{
    public static IServiceCollection addTipoMovimientoExtension(this IServiceCollection services)
    {
        services.AddTransient<ITipoMovimientoRepositorio, TipoMovimientoRepositorio>();
        services.AddTransient<ITipoMovimientoDAC, TipoMovimientoDAC>();
        return services;
    }
}
