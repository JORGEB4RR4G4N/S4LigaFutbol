namespace S4.LigaFutbol.Front.Componentes.Catalogos;

public partial class GridCatalogosComponent
{
    [Parameter] public IQueryable<TiposSancion> ListaTiposSancion { get; set; } = Enumerable.Empty<TiposSancion>().AsQueryable();
    [Parameter] public IQueryable<TiposPartido> ListaTiposPartidos { get; set; } = Enumerable.Empty<TiposPartido>().AsQueryable();
    [Parameter] public IQueryable<PosicionesJugador> ListaPosicionesJugadors { get; set; } = Enumerable.Empty<PosicionesJugador>().AsQueryable();
    [Parameter] public IQueryable<FasesTorneoDTO> ListaFasesTorneoDTO { get; set; } = Enumerable.Empty<FasesTorneoDTO>().AsQueryable();
    [Parameter] public IQueryable<Torneos> ListaTorneo { get; set; } = Enumerable.Empty<Torneos>().AsQueryable();

    [Parameter] public bool Cargando { get; set; }


    public TiposSancion TiposSancionSelected { get; set; } = new TiposSancion();
    public TiposPartido TiposPartidoSelected { get; set; } = new TiposPartido();
    public PosicionesJugador PosicionesJugadorsSelected { get; set; } = new PosicionesJugador();
    public FasesTorneoDTO FasesTorneoDTOSelected { get; set; } = new FasesTorneoDTO();
    public Torneos TorneosSelected { get; set; } = new Torneos();


}
