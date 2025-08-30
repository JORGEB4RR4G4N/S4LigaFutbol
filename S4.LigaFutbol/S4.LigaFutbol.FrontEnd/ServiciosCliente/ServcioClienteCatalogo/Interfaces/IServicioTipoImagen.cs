namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;
public interface IServicioTipoImagen
{
    Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<List<TiposImagen>> ListaTipoImagen();
    Task<TiposImagen> TipoImagen(int IdTipoImagen);
}
