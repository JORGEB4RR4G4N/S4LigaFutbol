namespace S4.LigaFutbol.Repositorio.Catalogos.Extensiones;

public static class FaseTorneoExtension
{
    public static IServiceCollection addFaseTorneoExtension(this IServiceCollection services)
    {
        services.AddTransient<IFasesTorneoRepositorio, FasesTorneoRepositorio>();
        services.AddTransient<IFasesTorneoDAC, FasesTorneoDAC>();
        return services;
    }

}

