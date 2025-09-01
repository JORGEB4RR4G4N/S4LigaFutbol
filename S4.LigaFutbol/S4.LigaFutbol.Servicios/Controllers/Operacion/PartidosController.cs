namespace S4.LigaFutbol.Servicios.Controllers.Operacion;
[Area("Operacion")]
[ApiController]
[Route("[area]/[controller]")]
public class PartidosController : Controller
{
    private readonly ILogger<PartidosController> logger;
    private readonly IPartidoRepositorio partidoRepositorio;
    private readonly int IdUsuario = 1;

    public PartidosController(ILogger<PartidosController> logger,
                            IPartidoRepositorio partidoRepositorio)
    {
        this.logger = logger;
        this.partidoRepositorio = partidoRepositorio;
    }

    [HttpGet]
    [Route("ListaPartidoCalendario")]
    public async Task<List<PartidosCalendarioDTO>> ListaPartidoCalendario([FromQuery] int? IdTorneo,
                                                                          [FromQuery] int? IdFase,
                                                                          [FromQuery] int? IdEstadoPartido)
    {
        return await partidoRepositorio.ListaPartidoCalendario(IdTorneo, IdFase, IdEstadoPartido);
    }
    [HttpPost]
    [Route("InsertarPartidos")]
    public async Task<bool> InsertarPartidos(Partidos partidos) => await partidoRepositorio.InsertarPartidos(partidos, IdUsuario);
    [HttpPost]
    [Route("InsertarProgramarPartidos")]
    public async Task<bool> InsertarProgramarPartidos(Partidos partidos) => await partidoRepositorio.InsertarProgramarPartidos(partidos, IdUsuario);
    [HttpPost]
    [Route("InsertarProgramaPartidosAdicional")]
    public async Task<bool> InsertarProgramaPartidosAdicional(Partidos partidos) => await partidoRepositorio.InsertarProgramaPartidosAdicional(partidos, IdUsuario);
    [HttpPut]
    [Route("ActualizarPartidoResultado")]
    public async Task<bool> ActualizarPartidoResultado(Partidos partidos)
    {
        if (partidos == null)
            throw new Exception("No contienen informacion");
        if (partidos.IdPartido == 0)
            throw new Exception("No contienen el IdPartido para modificar el datos");

        return await partidoRepositorio.ActualizarPartidoResultado(partidos, IdUsuario);
    }
    [HttpPut]
    [Route("ActualizaTorneo")]
    public async Task<bool> ActualizaTorneo([FromQuery] int IdPartido,
                                            [FromQuery] string? Motivo)
    {
        if (IdPartido == 0)
        {
            logger.LogError("No contienen el IdPartido para modificar el datos");
            throw new Exception("No contienen el IdPartido para modificar el datos");
        }


        return await partidoRepositorio.ActualizarCancelarPartido(IdPartido, Motivo, IdUsuario);
    }

}
