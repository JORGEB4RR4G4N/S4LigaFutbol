namespace S4.LigaFutbol.Comunes.Catalogos;

public class FasesTorneo
{
    public int IdFase { get; set; }
    public int IdTorneo { get; set; }
    public string Nombre { get; set; }
    public bool EsEliminatoria { get; set; }
    public bool EquiposQueClasifican { get; set; }
    public int Orden { get; set; }
    public DateTime FechaInicio { get; set; }
}
