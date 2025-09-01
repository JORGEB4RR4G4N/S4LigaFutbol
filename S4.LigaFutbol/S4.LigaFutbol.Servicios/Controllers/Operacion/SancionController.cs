namespace S4.LigaFutbol.Servicios.Controllers.Operacion;

[Area("Operacion")]
[ApiController]
[Route("[area]/[controller]")]
public class SancionController : Controller
{
    private readonly ILogger<SancionController> logger;
    private readonly ISancionRepositorio sancionRepositorio;
    private readonly int IdUsuario = 1;

    public SancionController(ILogger<SancionController> logger,
                            ISancionRepositorio sancionRepositorio)
    {
        this.logger = logger;
        this.sancionRepositorio = sancionRepositorio;
    }

    [HttpGet]
    [Route("ListaSancionesEnTorneo")]
    public async Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo) => await sancionRepositorio.ListaSancionesEnTorneo(IdTorneo);

    [HttpGet]
    [Route("ListaSancionesJugador/{IdJugador}")]
    public async Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador)
    {
        if (IdJugador > 0)
            return await sancionRepositorio.ListaSancionesJugador(IdJugador);
        else
        {
            logger.LogError("IdJugador no existe");
            return new List<SancionesJugadorDTO>();
        }

    }

    [HttpPost]
    public async Task<bool> InsertaTorneo(Sanciones sanciones)
    {
        return await sancionRepositorio.InsertarSancion(sanciones, IdUsuario);
    }
    [HttpDelete]
    public async Task<bool> ActualizaTorneo(int IdSancion)
    {
        if (IdSancion == 0)
        {
            logger.LogError("No contienen el IdSancion para modificar el datos");
            throw new Exception("No contienen el IdSancion para modificar el datos");
        }
        return await sancionRepositorio.ElimnarSancion(IdSancion, IdUsuario);
    }

}
