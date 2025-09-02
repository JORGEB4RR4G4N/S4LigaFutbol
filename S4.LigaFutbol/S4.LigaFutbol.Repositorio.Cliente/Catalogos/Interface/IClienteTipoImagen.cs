namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;
public interface IClienteTipoImagen
{
    Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen);
    Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen);
    Task<List<TiposImagen>> ListaTipoImagen();
    Task<TiposImagen> TipoImagen(int IdTipoImagen);
}
