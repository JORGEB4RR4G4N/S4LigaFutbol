

namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;

[Route("[controller]")]
[ApiController]
public class TorneoController : Controller
{
    private readonly ILogger<TorneoController> logger;
    private readonly ITorneoRepositorio torneoRepositorio;
    private readonly int IdUsuario = 1;

    public TorneoController(ILogger<TorneoController> logger,
                            ITorneoRepositorio torneoRepositorio)
    {
        this.logger = logger;
        this.torneoRepositorio = torneoRepositorio;
    }

    [HttpGet]
    public async Task<List<Torneos>> ListaTorneos()
    {
        return await torneoRepositorio.ListaTorneo();
    }
    [HttpGet]
    [Route("ObtieneTorneo/{IdTorneo}")]
    public async Task<Torneos> Torneos(int IdTorneo)
    {
        if (IdTorneo > 0)
            return await torneoRepositorio.Torneo(IdTorneo);
        else
        {
            logger.LogError("IdTorneo no existe");
            return new Torneos();
        }

    }

    [HttpPost]
    public async Task<Torneos> InsertaTorneo(Torneos torneo)
    {
        return await torneoRepositorio.InsertarTorneo(torneo, IdUsuario);
    }
    [HttpPut]
    public async Task<Torneos> ActualizaFalta(Torneos torneo)
    {
        if (torneo == null)
            throw new Exception("No contienen informacion");
        if (torneo.IdTorneo == 0)
            throw new Exception("No contienen el IdFalta para modificar el datos");

        return await torneoRepositorio.ActualizarTorneo(torneo, IdUsuario);
    }



}
