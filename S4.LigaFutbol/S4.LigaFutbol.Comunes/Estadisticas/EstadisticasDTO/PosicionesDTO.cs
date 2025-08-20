namespace S4.LigaFutbol.Comunes.Estadisticas.EstadisticasDTO;

public class PosicionesDTO
{
    public int IdEquipo { get; set; }
    public string Nombre { get; set; }
    public int Jugados { get; set; }

    public int Ganados { get; set; }
    public int Empatados { get; set; }
    public int Perdidos { get; set; }
    public int GolesAFavor { get; set; }
    public int GolesContra { get; set; }
    public int DiferenciaGol { get; set; }
    public int Puntos { get; set; }
}
