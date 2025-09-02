namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class TipoImagenController : ControllerBase
{
    private readonly ILogger<TipoImagenController> logger;
    private readonly ITipoImagenRepositorio tipoImagenRepositorio;
    private readonly int IdUsuario = 1;

    public TipoImagenController(ILogger<TipoImagenController> logger,
                            ITipoImagenRepositorio tipoImagenRepositorio)
    {
        this.logger = logger;
        this.tipoImagenRepositorio = tipoImagenRepositorio;
    }

    [HttpGet]
    public async Task<List<TiposImagen>> ListaTipoImagen()
    {
        return await tipoImagenRepositorio.ListaTipoImagen();
    }
    [HttpGet]
    [Route("ObtieneTipoImagen/{IdTipoImagen}")]
    public async Task<TiposImagen> TipoImagen(int IdTipoImagen)
    {
        if (IdTipoImagen > 0)
            return await tipoImagenRepositorio.TipoImagen(IdTipoImagen);
        else
        {
            logger.LogError("IdTipoImagen no existe");
            return new TiposImagen();
        }

    }

    [HttpPost]
    public async Task<TiposImagen> InsertaTipoImagen(TiposImagen tiposImagen)
    {
        return await tipoImagenRepositorio.InsertarTipoImagen(tiposImagen, IdUsuario);
    }
    [HttpPut]
    public async Task<TiposImagen> ActualizaTipoImagen(TiposImagen tiposImagen)
    {
        if (tiposImagen == null)
            throw new Exception("No contienen informacion");
        if (tiposImagen.IdTipoImagen == 0)
            throw new Exception("No contienen el IdTipoImagen para modificar el datos");

        return await tipoImagenRepositorio.ActualizarTipoImagen(tiposImagen, IdUsuario);
    }
}
