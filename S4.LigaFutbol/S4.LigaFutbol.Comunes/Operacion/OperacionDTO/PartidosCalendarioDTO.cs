namespace S4.LigaFutbol.Comunes.Operacion.OperacionDTO;

public class PartidosCalendarioDTO
{
    public int IdPartido { get; set; }
    public int IdTorneo { get; set; }
    public string Torneo { get; set; } = string.Empty;
    public int IdFase { get; set; }
    public string Fase { get; set; } = string.Empty;
    public int? IdJornada { get; set; }
    public int? Jornada { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan Hora { get; set; }
    public int IdEquipoLocal { get; set; }
    public string EquipoLocal { get; set; } = string.Empty;
    public int IdEquipoVisitante { get; set; }
    public string EquipoVisitante { get; set; } = string.Empty;
    public int IdTipoPartido { get; set; }
    public string TipoPartido { get; set; } = string.Empty;
    public int IdEstadoPartido { get; set; }
    public string EstadoPartido { get; set; } = string.Empty;
    public string CodigoEstado { get; set; } = string.Empty;
    public string Estadio { get; set; } = string.Empty;
    public string Observaciones { get; set; } = string.Empty;
}
