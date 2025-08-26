namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class PartidoExtension
{
    public static IServiceCollection addPartidoExtension(this IServiceCollection services)
    {
        services.AddTransient<IPartidoRepositorio, PartidoRepositorio>();
        services.AddTransient<IPartidoDAC, PartidoDAC>();
        return services;
    }
}
