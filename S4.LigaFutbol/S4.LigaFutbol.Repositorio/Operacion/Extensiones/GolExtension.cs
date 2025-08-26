namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class GolExtension
{
    public static IServiceCollection addGolExtension(this IServiceCollection services)
    {
        services.AddTransient<IGolRepositorio, GolRepositorio>();
        services.AddTransient<IGolDAC, GolDAC>();
        return services;
    }
}
