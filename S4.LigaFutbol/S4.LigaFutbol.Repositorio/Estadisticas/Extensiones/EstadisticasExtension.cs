namespace S4.LigaFutbol.Repositorio.Estadisticas.Extensiones;

public static class EstadisticasExtension
{
    public static IServiceCollection addEstadisticasExtension(this IServiceCollection services)
    {
        services.AddTransient<IEstadisticasRepositorio, EstadisticasRepositorio>();
        services.AddTransient<IEstadisticasDAC, EstadisticasDAC>();
        return services;
    }
}
