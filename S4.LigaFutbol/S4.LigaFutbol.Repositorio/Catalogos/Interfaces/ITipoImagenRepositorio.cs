namespace S4.LigaFutbol.Repositorio.Catalogos.Interfaces;
public interface ITipoImagenRepositorio
{
    Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<List<TiposImagen>> ListaTipoImagen();
    Task<TiposImagen> TipoImagen(int IdTipoImagen);
}
