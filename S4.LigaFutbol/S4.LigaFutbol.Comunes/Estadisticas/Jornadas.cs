namespace S4.LigaFutbol.Comunes.Estadisticas;

public class Jornadas
{
    public int IdJornada { get; set; }
    public int IdFase { get; set; }
    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public int IdTipoJornada { get; set; }
    public bool EsOficial { get; set; }
}
