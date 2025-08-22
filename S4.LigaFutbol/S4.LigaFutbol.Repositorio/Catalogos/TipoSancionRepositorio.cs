namespace S4.LigaFutbol.Repositorio.Catalogos;

public class TipoSancionRepositorio : ITipoSancionRepositorio
{
    private readonly ITipoSancionDAC tipoSancionDAC;

    public TipoSancionRepositorio(ITipoSancionDAC tipoSancionDAC)
    {
        this.tipoSancionDAC = tipoSancionDAC;
    }

    public async Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion, int IdUsuario)
    {
        TiposSancion tiposSancionObjeto = new TiposSancion();

        var DatoActualizado = await tipoSancionDAC.ActualizarTipoSancion(tiposSancion, IdUsuario);
        if (DatoActualizado)
            tiposSancionObjeto = tiposSancion;

        return tiposSancionObjeto;
    }

    public async Task<TiposSancion> TipoSancion(int IdTipoSancion)
    {
        TiposSancion tiposSancionObjeto = new TiposSancion();
        tiposSancionObjeto = await tipoSancionDAC.TipoSancion(IdTipoSancion);
        return tiposSancionObjeto;
    }

    public async Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion, int IdUsuario)
    {
        TiposSancion tiposSancionObjeto = new TiposSancion();

        var IdTipoSancion = await tipoSancionDAC.InsertarTipoSancion(tiposSancion, IdUsuario);

        if (IdTipoSancion > 0)
            tiposSancionObjeto = await tipoSancionDAC.TipoSancion(IdTipoSancion);

        return tiposSancionObjeto; ;
    }

    public async Task<List<TiposSancion>> ListaTipoSancion()
    {
        List<TiposSancion> ListaTiposSancionObjeto = new List<TiposSancion>();

        ListaTiposSancionObjeto = await tipoSancionDAC.ListaTipoSancion();

        return ListaTiposSancionObjeto;
    }
}
