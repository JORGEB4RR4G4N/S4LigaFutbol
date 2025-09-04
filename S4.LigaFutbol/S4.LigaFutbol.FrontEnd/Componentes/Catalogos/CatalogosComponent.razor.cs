using S4.LigaFutbol.Comunes.Catalogos;

namespace S4.LigaFutbol.FrontEnd.Componentes.Catalogos;

public partial class CatalogosComponent
{
    [Inject] public IClienteTipoSancion clienteTipoSancion { get; set; }
    [Inject] public IClienteTipoPartido clienteTipoPartido { get; set; }
    [Inject] public IClientePosicionJugador clientePosicionJugador { get; set; }

    public List<TiposSancion> ListaTiposSancion { get; set; } = new List<TiposSancion>();
    public List<TiposPartido> ListaTiposPartidos { get; set; } = new List<TiposPartido>();
    public List<PosicionesJugador> ListaposicionesJugadors { get; set; } = new List<PosicionesJugador>();


    protected override async Task OnInitializedAsync()
    {
        await CargaDatos();

    }

    public async Task CargaDatos()
    {
        ListaTiposSancion = await clienteTipoSancion.ListaTipoSancion();
        ListaTiposPartidos = await clienteTipoPartido.ListaTipoPartidos();
        ListaposicionesJugadors = await clientePosicionJugador.ListaPosicionJugador();
    }


    string selectedTab = "TipoPartido";

    private Task OnSelectedTabChanged(string name)
    {
        selectedTab = name;

        return Task.CompletedTask;
    }
}
