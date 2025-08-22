namespace S4.LigaFutbol.Repositorio.Catalogos.Interfaces;

public interface ITipoMovimientoRepositorio
{
    Task<TiposMovimiento> InsertarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario);
    Task<TiposMovimiento> ActualizarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario);
    Task<List<TiposMovimiento>> ListaTiposMovimientos();
    Task<TiposMovimiento> TipoMovimiento(int IdTipoMovimiento);
}
