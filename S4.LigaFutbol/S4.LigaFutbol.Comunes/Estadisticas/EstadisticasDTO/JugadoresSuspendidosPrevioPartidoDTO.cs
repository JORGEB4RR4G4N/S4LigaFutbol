namespace S4.LigaFutbol.Comunes.Estadisticas.EstadisticasDTO;

public class JugadoresSuspendidosPrevioPartidoDTO
{
    public string TipoEquipo { get; set; }
    public int IdJugador { get; set; }
    public string Jugador { get; set; }
    public string Numero { get; set; }
    public string Equipo { get; set; }
    public int PartidoSuspension { get; set; }
    public string TipoSancion { get; set; }
    public DateTime FechaSancion { get; set; }
}
