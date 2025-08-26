namespace S4.LigaFutbol.Servicios.Controllers.Estadisticas;

public class EstadisticasController : Controller
{

    private readonly ILogger<EstadisticasController> logger;
    private readonly IEstadisticasRepositorio estadisticasRepositorio;

    public EstadisticasController(ILogger<EstadisticasController> logger,
                            IEstadisticasRepositorio estadisticasRepositorio)
    {
        this.logger = logger;
        this.estadisticasRepositorio = estadisticasRepositorio;
    }

    [HttpGet]
    [Route("ObtieneListaPosicionesPorTorneo/{IdTorneo}")]
    public async Task<List<PosicionesDTO>> ListaPosicionesPorTorneo(int IdTorneo) => await estadisticasRepositorio.ListaPosicionesPorTorneo(IdTorneo);
    [HttpGet]
    [Route("ObtieneListaPosicionesPorFase/{IdFase}")]
    public async Task<List<PosicionesDTO>> ListaPosicionesPorFase(int IdFase) => await estadisticasRepositorio.ListaPosicionesPorFase(IdFase);

    [HttpGet]
    [Route("ListaEnfrentamientosHistoricos/{IdEquipoLocal}/{IdEquipoVisitante}")]
    public async Task<List<EnfrentamientoDTO>> ListaEnfrentamientosHistoricos(int IdEquipoLocal, int IdEquipoVisitante) => await estadisticasRepositorio.ListaEnfrentamientosHistoricos(IdEquipoLocal, IdEquipoVisitante);

    [HttpGet]
    [Route("ListaJugadoresSuspendidos")]
    [ProducesResponseType(typeof(IEnumerable<JugadoresSuspendidosDTOS>), StatusCodes.Status200OK)]
    public async Task<List<JugadoresSuspendidosDTOS>> ListaJugadoresSuspendidos([FromQuery] int? IdTorneo,
                                                                                [FromQuery] int? IdFase,
                                                                                [FromQuery] int? IdEquipo,
                                                                                [FromQuery] bool Activos)
   => await estadisticasRepositorio.ListaJugadoresSuspendidos(IdTorneo, IdFase, IdEquipo, Activos);



    [HttpGet]
    [Route("ListaJugadoresSuspendidosPrevioPartido/{IdPartido}")]
    public async Task<List<JugadoresSuspendidosPrevioPartidoDTO>> ListaJugadoresSuspendidosPrevioPartido(int IdPartido) => await estadisticasRepositorio.ListaJugadoresSuspendidosPrevioPartido(IdPartido);

    [HttpGet]
    [Route("ListaTopGoleadores/{IdTorneo}")]
    public async Task<List<GoleadoresDTO>> ListaTopGoleadores(int IdTorneo) => await estadisticasRepositorio.ListaTopGoleadores(IdTorneo);
    [HttpGet]
    [Route("ListaTopGoleadoresPorEquipo/{IdEquipo}")]
    public async Task<List<Jugadores>> ListaTopGoleadoresPorEquipo(int IdEquipo) => await estadisticasRepositorio.ListaTopGoleadoresPorEquipo(IdEquipo);

}
