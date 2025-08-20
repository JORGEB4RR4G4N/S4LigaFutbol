namespace S4.LigaFutbol.Comunes.Estadisticas.EstadisticasDTO;

public class EnfrentamientoDTO
{
    public int IdPartido { get; set; }
    public DateTime Fecha { get; set; }
    public string EquipoLocal { get; set; }
    public string EquipoVisitante { get; set; }
    public int  GolesLocal { get; set; }
    public int  GolesVisitante { get; set; }
}
