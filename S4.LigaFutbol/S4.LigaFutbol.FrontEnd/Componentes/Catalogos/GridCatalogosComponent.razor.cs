namespace S4.LigaFutbol.FrontEnd.Componentes.Catalogos;

public partial class GridCatalogosComponent
{

    [Parameter] public List<TiposSancion> ListaTiposSancion { get; set; } = new List<TiposSancion>();
    [Parameter] public List<TiposPartido> ListaTiposPartidos { get; set; } = new List<TiposPartido>();
    [Parameter] public List<PosicionesJugador> ListaposicionesJugadors { get; set; } = new List<PosicionesJugador>();

    public TiposSancion TiposSancionSelected { get; set; } = new TiposSancion();

}
