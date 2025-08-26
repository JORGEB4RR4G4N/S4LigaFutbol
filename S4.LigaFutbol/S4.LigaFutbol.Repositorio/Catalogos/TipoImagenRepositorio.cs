namespace S4.LigaFutbol.Repositorio.Catalogos;

public class TipoImagenRepositorio : ITipoImagenRepositorio
{
    private readonly ITipoImagenDAC tipoImageneDAC;
    public TipoImagenRepositorio(ITipoImagenDAC tipoImageneDAC)
    {
        this.tipoImageneDAC = tipoImageneDAC;
    }

    public async Task<TiposImagen> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario)
    {
        var Actualizado = await tipoImageneDAC.ActualizarTipoImagen(tiposImagen, IdUsuario);
        if (Actualizado)
            return tiposImagen;
        else
            return new TiposImagen();

    }

    public async Task<TiposImagen> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario)
    {
        TiposImagen tiposImagenObjecto = new TiposImagen();

        var IdTipoImagen = await tipoImageneDAC.InsertarTipoImagen(tiposImagen, IdUsuario);
        if (IdTipoImagen > 0)
            tiposImagenObjecto = await tipoImageneDAC.TipoImagen(IdTipoImagen);


        return tiposImagenObjecto;
    }

    public async Task<List<TiposImagen>> ListaTipoImagen()
    {
        List<TiposImagen> ListaTiposImagenObjecto = new List<TiposImagen>();
        ListaTiposImagenObjecto = await tipoImageneDAC.ListaTipoImagen();

        return ListaTiposImagenObjecto;
    }

    public async Task<TiposImagen> TipoImagen(int IdTipoImagen)
    {
        TiposImagen tiposImagenObjecto = new TiposImagen();
        tiposImagenObjecto = await tipoImageneDAC.TipoImagen(IdTipoImagen);

        return tiposImagenObjecto;
    }
}
