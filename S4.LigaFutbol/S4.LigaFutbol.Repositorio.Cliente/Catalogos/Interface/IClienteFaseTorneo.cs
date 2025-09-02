namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;
public interface IClienteFaseTorneo
{
    Task<FasesTorneo> InsertarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<FasesTorneo> ActualizarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<List<FasesTorneoDTO>> ListaFasesTorneo(int IdTorneo);
    Task<FasesTorneoDTO> FaseTorneo(int IdFase);
}
