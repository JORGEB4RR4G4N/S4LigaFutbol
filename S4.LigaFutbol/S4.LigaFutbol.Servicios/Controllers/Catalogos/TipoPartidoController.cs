namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class TipoPartidoController : ControllerBase
{
    private readonly ILogger<TipoPartidoController> logger;
    private readonly ITipoPartidoRepositorio tipoPartidoRepositorio;
    private readonly int IdUsuario = 1;

    public TipoPartidoController(ILogger<TipoPartidoController> logger,
                            ITipoPartidoRepositorio tipoPartidoRepositorio)
    {
        this.logger = logger;
        this.tipoPartidoRepositorio = tipoPartidoRepositorio;
    }

    [HttpGet]
    [Route("ListaTipoPartidos")]
    public async Task<List<TiposPartido>> ListaTipoPartidos()
    {
        return await tipoPartidoRepositorio.ListaTipoPartido();
    }
    [HttpGet]
    [Route("ObtieneTipoPartido/{IdTipoPartido}")]
    public async Task<TiposPartido> TipoPartido(int IdTipoPartido)
    {
        if (IdTipoPartido > 0)
            return await tipoPartidoRepositorio.TipoPartido(IdTipoPartido);
        else
        {
            logger.LogError("IdTipoPartido no existe");
            return new TiposPartido();
        }

    }

    [HttpPost]
    [Route("InsertaTipoPartido")]
    public async Task<TiposPartido> InsertaTipoPartido(TiposPartido tiposPartido)
    {
        return await tipoPartidoRepositorio.InsertarTipoPartido(tiposPartido, IdUsuario);
    }
    [HttpPut]
    [Route("ActualizaTipoPartido")]
    public async Task<TiposPartido> ActualizaTipoPartido(TiposPartido tiposPartido)
    {
        if (tiposPartido == null)
            throw new Exception("No contienen informacion");
        if (tiposPartido.IdTipoPartido == 0)
            throw new Exception("No contienen el IdTipoPartido para modificar el datos");

        return await tipoPartidoRepositorio.ActualizarTipoPartido(tiposPartido, IdUsuario);
    }

}
