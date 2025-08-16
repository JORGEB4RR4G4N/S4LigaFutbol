namespace S4.LigaFutbol.Comunes.Catalogos;

public class Sanciones : Extencion
{
    public int IdSancion { get; set; }
    public int IdPartido { get; set; }
    public int IdJugador { get; set; }
    public int IdTipoSancion { get; set; }
    public int Minuto { get; set; }
    public string Observacion { get; set; }
    public DateTime FechaSancion { get; set; }
    public int PartidosSuspension { get; set; }
    public bool EsDobleAmarilla { get; set; }
}
