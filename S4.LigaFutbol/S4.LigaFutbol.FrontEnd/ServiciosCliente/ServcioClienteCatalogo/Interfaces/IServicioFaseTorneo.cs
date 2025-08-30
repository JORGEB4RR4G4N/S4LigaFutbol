namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;
public interface IServicioFaseTorneo
{
    Task<FasesTorneo> InsertarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<FasesTorneo> ActualizarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario);
    Task<List<FasesTorneoDTO>> ListaFasesTorneo(int IdTorneo);
    Task<FasesTorneoDTO> FaseTorneo(int IdFase);
}
