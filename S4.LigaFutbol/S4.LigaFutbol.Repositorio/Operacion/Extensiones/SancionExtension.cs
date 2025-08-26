namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class SancionExtension
{
    public static IServiceCollection addSancionExtension(this IServiceCollection services)
    {
        services.AddTransient<ISancionRepositorio, SancionRepositorio>();
        services.AddTransient<ISancionDAC, SancionDAC>();
        return services;
    }
}
