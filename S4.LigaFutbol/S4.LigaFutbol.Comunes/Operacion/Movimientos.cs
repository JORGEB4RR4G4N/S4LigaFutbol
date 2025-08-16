namespace S4.LigaFutbol.Comunes.Operacion;

public class Movimientos
{
    public int IdMovimiento { get; set; }
    public int IdUsuario { get; set; }
    public int IdTipoMovimiento { get; set; }
    public string TablaAfectada { get; set; }
    public DateTime FechaMovimiento { get; set; }
    public string Observacion { get; set; }
}
