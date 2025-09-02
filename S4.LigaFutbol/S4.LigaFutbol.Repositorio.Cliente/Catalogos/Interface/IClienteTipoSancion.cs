namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos.Interface;

public interface IClienteTipoSancion
{
    Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion);
    Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion);
    Task<List<TiposSancion>> ListaTipoSancion();
    Task<TiposSancion> TipoSancion(int IdTipoSancion);

}
