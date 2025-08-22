
namespace S4.LigaFutbol.Repositorio.Catalogos;

public class TipoPartidoRepositorio : ITipoPartidoRepositorio
{
    public readonly ITipoPartidoDAC TipoPartidoDAC;
    public TipoPartidoRepositorio(ITipoPartidoDAC tipoPartidoDAC)
    {
        TipoPartidoDAC = tipoPartidoDAC;
    }

    public async Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        var TipoPartido = await TipoPartidoDAC.ActualizarTipoPartido(tiposPartido, IdUsuario);
        if (TipoPartido)
            return tiposPartido;
        else
            return new TiposPartido();
    }

    public async Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        TiposPartido tiposPartidoObjecto = new TiposPartido();
        var IdTipoPartido = await TipoPartidoDAC.InsertarTipoPartido(tiposPartido, IdUsuario);
        if (IdTipoPartido > 0)
            tiposPartidoObjecto = await TipoPartidoDAC.TipoPartido(IdTipoPartido);

        return tiposPartidoObjecto;
    }

    public async Task<List<TiposPartido>> ListaTipoPartido()
    {
        List<TiposPartido> ListaTiposPartidoObjecto = new List<TiposPartido>();

        ListaTiposPartidoObjecto = await TipoPartidoDAC.ListaTipoPartido();

        return ListaTiposPartidoObjecto;
    }

    public async Task<TiposPartido> TipoPartido(int IdTipoPartido)
    {
        TiposPartido tiposPartidoObjecto = new TiposPartido();
        tiposPartidoObjecto = await TipoPartidoDAC.TipoPartido(IdTipoPartido);
        return tiposPartidoObjecto;
    }
}
