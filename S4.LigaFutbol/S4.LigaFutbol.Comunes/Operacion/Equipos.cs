namespace S4.LigaFutbol.Comunes.Operacion;

public class Equipos
{
    public int IdEquipo { get; set; }
    public int IdTorneo { get; set; }
    public int IdOrigen { get; set; }
    public int IdImagen { get; set; }
    public string Nombre { get; set; }
    public bool Habilitado { get; set; }
    public DateTime FechaAlta { get; set; }
    public int IdUsuraio { get; set; }
}
