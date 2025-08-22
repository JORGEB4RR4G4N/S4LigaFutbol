namespace S4.LigaFutbol.Repositorio.Catalogos.Interfaces;

public interface ITipoPartidoRepositorio
{
    Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario);
    Task<List<TiposPartido>> ListaTipoPartido();
    Task<TiposPartido> TipoPartido(int IdTipoPartido);
}
