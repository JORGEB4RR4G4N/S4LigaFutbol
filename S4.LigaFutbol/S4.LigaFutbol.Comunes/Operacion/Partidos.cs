namespace S4.LigaFutbol.Comunes.Operacion;

public class Partidos
{
    public int IdPartido { get; set; }
    public int IdTorneo { get; set; }
    public int IdFase { get; set; }
    public int IdJornada { get; set; }
    public int IdEquipoLocal { get; set; }
    public int IdEquipoVisitante { get; set; }
    public int IdTipoPartido { get; set; }
    public int IdEstadoPartido { get; set; }
    public int IdUsuario { get; set; }
    public DateTime Fecha { get; set; }
    public int GolesLocal { get; set; }
    public int GolesVisitante { get; set; }
    public int Estadio { get; set; }
    public string Observacion { get; set; }
    public bool EsOficial { get; set; }
    public DateTime FechaAlta { get; set; }
    public DateTime FechaMovimiento { get; set; }
}
