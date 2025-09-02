namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;
public interface IClienteTipoImagen
{
    Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<List<TiposImagen>> ListaTipoImagen();
    Task<TiposImagen> TipoImagen(int IdTipoImagen);
}
