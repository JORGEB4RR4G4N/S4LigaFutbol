namespace S4.LigaFutbol.Repositorio.Catalogos.Interfaces;

public interface ITipoSancionRepositorio
{
    Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<List<TiposSancion>> ListaTipoSancion();
    Task<TiposSancion> TipoSancion(int IdTipoSancion);
}
