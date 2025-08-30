namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;
public interface IServicioTipoPartido
{
    Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<List<TiposPartido>> ListaTipoPartido();
    Task<TiposPartido> TipoPartido(int IdTipoPartido);
}
