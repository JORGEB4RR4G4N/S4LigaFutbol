namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class JugadorExtension
{
    public static IServiceCollection addJugadorExtension(this IServiceCollection services)
    {
        services.AddTransient<IJugadorRepositorio, JugadorRepositorio>();
        services.AddTransient<IJugadorDAC, JugadorDAC>();
        return services;
    }
}
