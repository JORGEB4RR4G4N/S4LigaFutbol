namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface ITorneoRepositorio
{
    Task<Torneos> InsertarTorneo(Torneos torneo, int IdUsuario);
    Task<Torneos> ActualizarTorneo(Torneos torneo, int IdUsuario);
    Task<List<Torneos>> ListaTorneo();
    Task<Torneos> Torneo(int IdTorneo);
}
