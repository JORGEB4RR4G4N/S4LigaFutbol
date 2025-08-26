namespace S4.LigaFutbol.Repositorio.Operacion.Extensiones;

public static class EquipoExtension
{
    public static IServiceCollection addEquipoExtension(this IServiceCollection services)
    {
        services.AddTransient<IEquipoRepositorio, EquipoRepositorio>();
        services.AddTransient<IEquipoDAC, EquipoDAC>();
        return services;
    }
}
