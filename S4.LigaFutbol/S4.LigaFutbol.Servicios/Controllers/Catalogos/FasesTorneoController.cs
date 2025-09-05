namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class FasesTorneoController : ControllerBase
{
    private readonly ILogger<FasesTorneoController> logger;
    private readonly IFasesTorneoRepositorio fasesTorneoRepositorio;
    private readonly int IdUsuario = 1;

    public FasesTorneoController(ILogger<FasesTorneoController> logger,
                           IFasesTorneoRepositorio fasesTorneoRepositorio)
    {
        this.logger = logger;
        this.fasesTorneoRepositorio = fasesTorneoRepositorio;
    }

    [HttpGet]
    [Route("ListaFasesTorneo/{IdTorneo?}")]
    public async Task<List<FasesTorneoDTO>> ListaFasesTorneo(int? IdTorneo)
    {
        return await fasesTorneoRepositorio.ListaFasesTorneo(IdTorneo);
    }
    [HttpGet]
    [Route("ObtieneFaseTorneo/{IdFase}")]
    public async Task<FasesTorneoDTO> FasesTorneos(int IdFase)
    {
        if (IdFase > 0)
            return await fasesTorneoRepositorio.FaseTorneo(IdFase);
        else
        {
            logger.LogError("IdTorneo no existe");
            return new FasesTorneoDTO();
        }

    }

    [HttpPost]
    [Route("InsertaFasesTorneo")]
    public async Task<FasesTorneo> InsertaFasesTorneo(FasesTorneo fasesTorneo)
    {
        return await fasesTorneoRepositorio.InsertarFaseTorneo(fasesTorneo, IdUsuario);
    }
    [HttpPut]
    [Route("ActualizaFasesTorneo")]
    public async Task<FasesTorneo> ActualizaFasesTorneo(FasesTorneo fasesTorneo)
    {
        if (fasesTorneo == null)
            throw new Exception("No contienen informacion");
        if (fasesTorneo.IdFase == 0)
            throw new Exception("No contienen el IdFasesTorneo para modificar el datos");

        return await fasesTorneoRepositorio.ActualizarFaseTorneo(fasesTorneo, IdUsuario);
    }

}
