namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;
public interface IClienteTipoPartido
{
    Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido);
    Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido);
    Task<List<TiposPartido>> ListaTipoPartido();
    Task<TiposPartido> TipoPartido(int IdTipoPartido);
}
