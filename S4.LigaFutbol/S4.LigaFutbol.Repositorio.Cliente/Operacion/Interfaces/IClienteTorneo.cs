namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClienteTorneo
{
    Task<Torneos> InsertarTorneo(Torneos torneo);
    Task<Torneos> ActualizarTorneo(Torneos torneo);
    Task<List<Torneos>> ListaTorneo();
    Task<Torneos> Torneo(int IdTorneo);
}
