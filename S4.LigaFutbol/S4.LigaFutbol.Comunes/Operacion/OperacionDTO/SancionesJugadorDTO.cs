namespace S4.LigaFutbol.Comunes.Operacion.OperacionDTO;

public class SancionesJugadorDTO
{
    public int IdSancion { get; set; }
    public string Tipo { get; set; }
    public DateTime FechaPartido { get; set; }
    public string EquipoRival { get; set; }
    public int Minuto { get; set; }
    public string Observaciones { get; set; }
    public int PartidosSuspension { get; set; }
}
