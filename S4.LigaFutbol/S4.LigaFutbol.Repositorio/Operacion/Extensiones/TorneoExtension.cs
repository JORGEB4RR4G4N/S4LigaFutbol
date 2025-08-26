namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class TorneoExtension
{
    public static IServiceCollection addTorneoExtension(this IServiceCollection services)
    {
        services.AddTransient<ITorneoRepositorio, TorneoRepositorio>();
        services.AddTransient<ITorneoDAC, TorneoDAC>();
        return services;
    }
}
