namespace S4.LigaFutbol.Servicios.Controllers.Operacion;
[Area("OperacionGeneral")]
[ApiController]
[Route("[area]/[controller]")]
public class JugadorController : Controller
{
    private readonly ILogger<JugadorController> logger;
    private readonly IJugadorRepositorio jugadorRepositorio;
    private readonly int IdUsuario = 1;

    public JugadorController(ILogger<JugadorController> logger,
                            IJugadorRepositorio jugadorRepositorio)
    {
        this.logger = logger;
        this.jugadorRepositorio = jugadorRepositorio;
    }

    [HttpGet]
    [Route("ListaJugadorPorTorneoEquipo/{IdTorneo}/{IdEquipo}")]
    public async Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo,int IdEquipo) => await jugadorRepositorio.ListaJugadorPorTorneoEquipo(IdTorneo, IdEquipo);

    [HttpPost]
    public async Task<Jugadores> InsertaTorneo(Jugadores jugadores)
    {
        if (jugadores == null)
        {
            logger.LogError("No contienen informacion");
            throw new Exception("No contienen informacion");
        }

        return await jugadorRepositorio.InsertarJugador(jugadores, IdUsuario);
    }
    [HttpPut]
    public async Task<Jugadores> ActualizaTorneo(Jugadores jugadores)
    {
        if (jugadores == null)
        {
            logger.LogError("No contienen informacion");
            throw new Exception("No contienen informacion");
        }

        if (jugadores.IdJugador == 0)
        {
            logger.LogError("No contienen el IdTorneo para modificar el datos");
            throw new Exception("No contienen el IdTorneo para modificar el datos");
        }
        return await jugadorRepositorio.ActualizarJugador(jugadores, IdUsuario);
    }

}
