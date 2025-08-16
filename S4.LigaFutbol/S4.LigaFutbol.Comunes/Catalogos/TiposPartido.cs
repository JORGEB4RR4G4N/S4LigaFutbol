namespace S4.LigaFutbol.Comunes.Catalogos;

public class TiposPartido
{
    public int IdTipoPartido { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool AfectaPosicion { get; set; }
    public bool EsOficial { get; set; }
}
