namespace S4.LigaFutbol.Servicios.Controllers.Operacion;
[Area("Operacion")]
[ApiController]
[Route("[area]/[controller]")]
public class EquipoController : ControllerBase
{
    private readonly ILogger<EquipoController> logger;
    private readonly IEquipoRepositorio equipoRepositorio;
    private readonly int IdUsuario = 1;

    public EquipoController(ILogger<EquipoController> logger,
                            IEquipoRepositorio equipoRepositorio)
    {
        this.logger = logger;
        this.equipoRepositorio = equipoRepositorio;
    }

    [HttpGet]
    [Route("ListaEquipo")]
    public async Task<List<EquiposDTO>> ListaEquipo(int IdTorneo) => await equipoRepositorio.ListaEquipo(null, IdTorneo);

    [HttpGet]
    [Route("Equipo")]
    public async Task<EquiposDTO> Equipo( int IdEquipo) => await equipoRepositorio.Equipo(IdEquipo);

    [HttpPost]
    [Route("InsertarEquipo")]
    public async Task<EquiposDTO> InsertarEquipo(Equipos equipos)
    {
        if (equipos == null)
        {
            logger.LogError("No contienen informacion");
            throw new Exception("No contienen informacion");
        }

        return await equipoRepositorio.InsertarEquipo(equipos, IdUsuario);
    }
    [HttpPut]
    [Route("ActualizarEquipo")]
    public async Task<EquiposDTO> ActualizarEquipo(Equipos equipos)
    {
        if (equipos == null)
        {
            logger.LogError("No contienen informacion");
            throw new Exception("No contienen informacion");
        }

        if (equipos.IdEquipo == 0)
        {
            logger.LogError("No contienen el IdEquipo para modificar el datos");
            throw new Exception("No contienen el IdEquipo para modificar el datos");
        }
        return await equipoRepositorio.ActualizarEquipo(equipos, IdUsuario);
    }
}
