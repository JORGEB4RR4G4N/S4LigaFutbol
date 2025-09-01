namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGenerales")]
[ApiController]
[Route("[area]/[controller]")]
public class TipoMovimientoController : ControllerBase
{
    private readonly ILogger<TipoMovimientoController> logger;
    private readonly ITipoMovimientoRepositorio tipoMovimientoRepositorio;
    private readonly int IdUsuario = 1;

    public TipoMovimientoController(ILogger<TipoMovimientoController> logger,
                            ITipoMovimientoRepositorio tipoMovimientoRepositorio)
    {
        this.logger = logger;
        this.tipoMovimientoRepositorio = tipoMovimientoRepositorio;
    }

    [HttpGet]
    public async Task<List<TiposMovimiento>> ListaTiposMovimientos()
    {
        return await tipoMovimientoRepositorio.ListaTiposMovimientos();
    }
    [HttpGet]
    [Route("ObtieneTipoMovimiento/{IdTipoMovimiento}")]
    public async Task<TiposMovimiento> TipoMovimiento(int IdTipoMovimiento)
    {
        if (IdTipoMovimiento > 0)
            return await tipoMovimientoRepositorio.TipoMovimiento(IdTipoMovimiento);
        else
        {
            logger.LogError("IdTipoMovimiento no existe");
            return new TiposMovimiento();
        }

    }

    [HttpPost]
    public async Task<TiposMovimiento> InsertaTipoMovimiento(TiposMovimiento tiposMovimiento)
    {
        return await tipoMovimientoRepositorio.InsertarTiposMovimiento(tiposMovimiento, IdUsuario);
    }
    [HttpPut]
    public async Task<TiposMovimiento> ActualizaTipoMovimiento(TiposMovimiento tiposMovimiento)
    {
        if (tiposMovimiento == null)
            throw new Exception("No contienen informacion");
        if (tiposMovimiento.IdTipoMovimiento == 0)
            throw new Exception("No contienen el IdTipoMovimiento para modificar el datos");

        return await tipoMovimientoRepositorio.ActualizarTiposMovimiento(tiposMovimiento, IdUsuario);
    }
}
