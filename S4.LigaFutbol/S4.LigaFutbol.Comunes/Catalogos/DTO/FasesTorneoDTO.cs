namespace S4.LigaFutbol.Comunes.Catalogos.DTO;

public class FasesTorneoDTO : FasesTorneo
{
    public string NombreTorneo { get; set; } = string.Empty;
    public string EsEliminatoriaTexto { get => EsEliminatoria ? "Si" : "No"; }
    public string EquiposQueClasificanTexto { get => EquiposQueClasifican ? "Si" : "No"; }
}
