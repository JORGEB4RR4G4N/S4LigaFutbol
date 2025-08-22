namespace S4.LigaFutbol.Repositorio.Catalogos;
public class TipoMovimientoRepositorio : ITipoMovimientoRepositorio
{
    private readonly ITipoMovimientoDAC tipoMovimientoDataAcces;
    public TipoMovimientoRepositorio(ITipoMovimientoDAC tipoMovimientoDataAcces)
    {
        this.tipoMovimientoDataAcces = tipoMovimientoDataAcces;
    }

    public async Task<TiposMovimiento> ActualizarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario)
    {
        bool DatoActualizado = await tipoMovimientoDataAcces.ActualizarTiposMovimiento(tiposMovimiento, IdUsuario);
        if (DatoActualizado)
            return tiposMovimiento;
        else
            return new TiposMovimiento();
    }

    public async Task<TiposMovimiento> InsertarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario)
    {
        TiposMovimiento tiposMovimientoObjecto = new TiposMovimiento();

        var IdTipoMovimeinto = await tipoMovimientoDataAcces.InsertarTiposMovimiento(tiposMovimiento, IdUsuario);
        if (IdTipoMovimeinto > 0)
            tiposMovimientoObjecto = await tipoMovimientoDataAcces.TipoMovimiento(IdTipoMovimeinto);

        return tiposMovimientoObjecto;
    }

    public async Task<List<TiposMovimiento>> ListaTiposMovimientos()
    {
        List<TiposMovimiento> ListaTiposMovimientoObjecto = new List<TiposMovimiento>();

        ListaTiposMovimientoObjecto = await tipoMovimientoDataAcces.ListaTiposMovimientoS();

        return ListaTiposMovimientoObjecto;
    }

    public async Task<TiposMovimiento> TipoMovimiento(int IdTipoMovimiento)
    {
        TiposMovimiento tiposMovimientoObjecto = new TiposMovimiento();

        tiposMovimientoObjecto = await tipoMovimientoDataAcces.TipoMovimiento(IdTipoMovimiento);

        return tiposMovimientoObjecto;
    }
}
