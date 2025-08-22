namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface ITipoMovimientoDAC
{
    Task<int> InsertarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario);
    Task<bool> ActualizarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario);
    Task<List<TiposMovimiento>> ListaTiposMovimientoS();
    Task<TiposMovimiento> TipoMovimiento(int IdTipoMovimiento);
}
