namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;
public static class PosicionTorneoExtension
{
    public static IServiceCollection addPosicionTorneoExtension(this IServiceCollection services)
    {
        services.AddTransient<IPosicionJugadorRepositorio, PosicionJugadorRepositorio>();
        services.AddTransient<IPosicionJugadorDAC, PosicionJugadorDAC>();
        return services;
    }
}
