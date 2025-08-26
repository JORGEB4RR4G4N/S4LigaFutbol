namespace S4.LigaFutbol.Servicios.Controllers.Catalogos;
[Route("[controller]")]
[ApiController]
public class PosicionJugadorController : Controller
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
    public async Task<List<PosicionesJugador>> ListaPosicionesJugador()
    {
        return await posicionJugadorRepositorio.ListaPosicionesJugador();
    }
    [HttpGet]
    [Route("ObtienePosicionJugador/{IdPosicionJugador}")]
    public async Task<PosicionesJugador> PosicionJugador(int IdPosicionJugador)
    {
        if (IdPosicionJugador > 0)
            return await posicionJugadorRepositorio.PosicionesJugador(IdPosicionJugador);
        else
        {
            logger.LogError("IdPosicionJugador no existe");
            return new PosicionesJugador();
        }

    }

    [HttpPost]
    public async Task<PosicionesJugador> InsertaPosicionJugador(PosicionesJugador posicionesJugador)
    {
        return await posicionJugadorRepositorio.InsertarPosicionesJugador(posicionesJugador, IdUsuario);
    }
    [HttpPut]
    public async Task<PosicionesJugador> ActualizaFalta(PosicionesJugador posicionesJugador)
    {
        if (posicionesJugador == null)
            throw new Exception("No contienen informacion");
        if (posicionesJugador.IdPosicionJugador == 0)
            throw new Exception("No contienen el IdPosicionJugador para modificar el datos");

        return await posicionJugadorRepositorio.ActualizarPosicionesJugador(posicionesJugador, IdUsuario);
    }

}
