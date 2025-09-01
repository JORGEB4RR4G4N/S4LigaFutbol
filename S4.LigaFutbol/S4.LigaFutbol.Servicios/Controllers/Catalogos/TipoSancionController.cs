namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGenerales")]
[ApiController]
[Route("[area]/[controller]")] 
public class TipoSancionController : ControllerBase
{
    private readonly ILogger<TipoSancionController> logger;
    private readonly ITipoSancionRepositorio tipoSancionRepositorio;
    private readonly int IdUsuario = 1;

    public TipoSancionController(ILogger<TipoSancionController> logger,
                            ITipoSancionRepositorio tipoSancionRepositorio)
    {
        this.logger = logger;
        this.tipoSancionRepositorio = tipoSancionRepositorio;
    }

    [HttpGet]
    [Route("ListaTipoSancion")]
    public async Task<List<TiposSancion>> ListaTipoSancion()
    {
        return await tipoSancionRepositorio.ListaTipoSancion();
    }
    [HttpGet]
    [Route("ObtieneTipoSancion/{IdTipoSancion}")]
    public async Task<TiposSancion> TipoSancion(int IdTipoSancion)
    {
        if (IdTipoSancion > 0)
            return await tipoSancionRepositorio.TipoSancion(IdTipoSancion);
        else
        {
            logger.LogError("IdTipoSancion no existe");
            return new TiposSancion();
        }

    }

    [HttpPost]
    public async Task<TiposSancion> InsertaTipoSancion(TiposSancion  tiposSancion)
    {
        return await tipoSancionRepositorio.InsertarTipoSancion(tiposSancion, IdUsuario);
    }
    [HttpPut]
    public async Task<TiposSancion> ActualizaTipoSancion(TiposSancion tiposSancion)
    {
        if (tiposSancion == null)
            throw new Exception("No contienen informacion");
        if (tiposSancion.IdTipoSancion == 0)
            throw new Exception("No contienen el IdTipoSancion para modificar el datos");

        return await tipoSancionRepositorio.ActualizarTipoSancion(tiposSancion, IdUsuario);
    }
}
