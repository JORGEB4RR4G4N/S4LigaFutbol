namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface ITipoPartidoDAC
{
    Task<int> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<bool> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<List<TiposPartido>> ListaTipoPartido();
    Task<TiposPartido> TipoPartido(int IdTipoPartido);
}
