namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Area("CatalogosGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class PosicionJugadorController : ControllerBase
{
    private readonly ILogger<PosicionJugadorController> logger;
    private readonly IPosicionJugadorRepositorio posicionJugadorRepositorio;
    private readonly int IdUsuario = 1;

    public PosicionJugadorController(ILogger<PosicionJugadorController> logger,
                            IPosicionJugadorRepositorio posicionJugadorRepositorio)
    {
        this.logger = logger;
        this.posicionJugadorRepositorio = posicionJugadorRepositorio;
    }

    [HttpGet]
    [Route("ListaPosicionJugador")]
    public async Task<List<PosicionesJugador>> ListaPosicionJugador()
    {
        return await posicionJugadorRepositorio.ListaPosicionJugador();
    }
    [HttpGet]
    [Route("ObtienePosicionJugador/{IdPosicionJugador}")]
    public async Task<PosicionesJugador> PosicionJugador(int IdPosicionJugador)
    {
        if (IdPosicionJugador > 0)
            return await posicionJugadorRepositorio.PosicionJugador(IdPosicionJugador);
        else
        {
            logger.LogError("IdPosicionJugador no existe");
            return new PosicionesJugador();
        }

    }

    [HttpPost]
    [Route("InsertaPosicionJugador")]
    public async Task<PosicionesJugador> InsertaPosicionJugador(PosicionesJugador posicionesJugador)
    {
        return await posicionJugadorRepositorio.InsertarPosicionJugador(posicionesJugador, IdUsuario);
    }
    [HttpPut]
    [Route("ActualizarPosicionJugador")]
    public async Task<PosicionesJugador> ActualizarPosicionJugador(PosicionesJugador posicionesJugador)
    {
        if (posicionesJugador == null)
            throw new Exception("No contienen informacion");
        if (posicionesJugador.IdPosicionJugador == 0)
            throw new Exception("No contienen el IdPosicionJugador para modificar el datos");

        return await posicionJugadorRepositorio.ActualizarPosicionJugador(posicionesJugador, IdUsuario);
    }

}
