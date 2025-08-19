namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface ITorneoDAC
{
    Task<int> InsertarTorneo(Torneos torneo, int IdUsuario);
    Task<bool> ActualizarTorneo(Torneos torneo, int IdUsuario);
    Task<List<Torneos>> ListaTorneo();
    Task<Torneos> Torneo(int IdTorneo);
}
