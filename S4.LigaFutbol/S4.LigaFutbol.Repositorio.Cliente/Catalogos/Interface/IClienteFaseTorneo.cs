namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;
public interface IClienteFaseTorneo
{
    Task<FasesTorneo> InsertarFaseTorneo(FasesTorneo fasesTorneo);
    Task<FasesTorneo> ActualizarFaseTorneo(FasesTorneo fasesTorneo);
    Task<List<FasesTorneoDTO>> ListaFasesTorneo(int IdTorneo);
    Task<FasesTorneoDTO> FaseTorneo(int IdFase);
}
