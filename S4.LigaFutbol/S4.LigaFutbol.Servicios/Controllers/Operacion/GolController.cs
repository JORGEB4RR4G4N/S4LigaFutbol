namespace S4.LigaFutbol.Servicios.Controllers.Operacion;
[Area("OperacionGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class GolController : Controller
{
    private readonly ILogger<GolController> logger;
    private readonly IGolRepositorio golRepositorio;
    private readonly int IdUsuario = 1;

    public GolController(ILogger<GolController> logger,
                            IGolRepositorio golRepositorio)
    {
        this.logger = logger;
        this.golRepositorio = golRepositorio;
    }

    [HttpGet]
    [Route("ListaGolesPartido")]
    public async Task<List<GolesJugadorDTO>> ListaGolesPartido([FromBody] int IdPartido) => await golRepositorio.ListaGolesPartido(IdPartido);

    [HttpPost]
    [Route("InsertarGol")]
    public async Task<Goles> InsertarGol(Goles goles)
    {
        if (goles == null)
        {
            logger.LogError("No contienen informacion");
            throw new Exception("No contienen informacion");
        }

        return await golRepositorio.InsertarGol(goles, IdUsuario);
    }
    [HttpDelete]
    [Route("EliminarGol")]
    public async Task<bool> EliminarGol([FromBody] int IdGol)
    {
        if (IdGol == 0)
        {
            logger.LogError("No contienen el IdTorneo para modificar el datos");
            throw new Exception("No contienen el IdGol para modificar el datos");
        }
        return await golRepositorio.EliminarGol(IdGol, IdUsuario);
    }
}
