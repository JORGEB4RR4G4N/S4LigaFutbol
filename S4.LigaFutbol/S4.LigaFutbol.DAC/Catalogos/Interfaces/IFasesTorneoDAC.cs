namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface IFasesTorneoDAC
{
    Task<int> InsertarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<bool> ActualizarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<List<FasesTorneoDTO>> ListaFasesTorneo(int? IdTorneo);
    Task<FasesTorneoDTO> FaseTorneo(int IdFase);
}
