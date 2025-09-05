namespace S4.LigaFutbol.FrontEnd.Componentes.Catalogos;

public partial class GridCatalogosComponent
{

    [Parameter] public List<TiposSancion> ListaTiposSancion { get; set; } = new List<TiposSancion>();
    [Parameter] public List<TiposPartido> ListaTiposPartidos { get; set; } = new List<TiposPartido>();
    [Parameter] public List<PosicionesJugador> ListaPosicionesJugadors { get; set; } = new List<PosicionesJugador>();
    [Parameter] public List<FasesTorneoDTO> ListaFasesTorneoDTO { get; set; } = new List<FasesTorneoDTO>();
    [Parameter] public List<Torneos> ListaTorneo { get; set; } = new List<Torneos>();


    public TiposSancion TiposSancionSelected { get; set; } = new TiposSancion();
    public TiposPartido TiposPartidoSelected { get; set; } = new TiposPartido();
    public PosicionesJugador PosicionesJugadorsSelected { get; set; } = new PosicionesJugador();
    public FasesTorneoDTO FasesTorneoDTOSelected { get; set; } = new FasesTorneoDTO();
    public Torneos TorneosSelected { get; set; } = new Torneos();
    private VirtualizeOptions virtualizeOptions = new VirtualizeOptions { DataGridHeight = "500px" };

}
