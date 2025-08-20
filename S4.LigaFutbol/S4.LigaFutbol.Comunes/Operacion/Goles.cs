namespace S4.LigaFutbol.Comunes.Operacion;

public class Goles
{
    public int IdGol { get; set; }
    public int IdPartido { get; set; }
    public int IdJugador { get; set; }
    public int Mintuo { get; set; }
    public bool EsPenalti { get; set; }
    public bool EsFalta { get; set; }
    public int IdJugadorAsistencia { get; set; }
}
