namespace S4.LigaFutbol.Comunes.Operacion;
public class Torneos
{
    public int IdTorneo { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIncio { get; set; }
    public DateTime FechaFin { get; set; }
    public bool Habilitado { get; set; }
    public int IdUsuario { get; set; }
    public DateTime FechaAlta { get; set; }
}
