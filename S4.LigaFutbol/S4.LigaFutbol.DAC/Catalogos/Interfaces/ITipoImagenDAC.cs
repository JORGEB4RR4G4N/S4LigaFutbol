namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface ITipoImagenDAC
{
    Task<int> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<bool> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario);
    Task<List<TiposImagen>> ListaTipoImagen();
    Task<TiposImagen> TipoImagen(int IdTipoImagen);
}
