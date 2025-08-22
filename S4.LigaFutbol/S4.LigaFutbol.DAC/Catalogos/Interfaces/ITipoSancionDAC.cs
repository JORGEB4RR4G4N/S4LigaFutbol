namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface ITipoSancionDAC
{
    Task<int> InsertarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<bool> ActualizarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<List<TiposSancion>> ListaTipoSancion();
    Task<TiposSancion> TipoSancion(int IdTipoSancion);
}
