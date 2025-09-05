

namespace S4.LigaFutbol.FrontEnd.Componentes.Catalogos;

public partial class CatalogosComponent
{
    [Inject] public IClienteTipoSancion clienteTipoSancion { get; set; }
    [Inject] public IClienteTipoPartido clienteTipoPartido { get; set; }
    [Inject] public IClientePosicionJugador clientePosicionJugador { get; set; }
    [Inject] public IClienteFaseTorneo clienteFaseTorneo { get; set; }
    [Inject] public IClienteTorneo clienteTorneo { get; set; }

    public List<TiposSancion> ListaTiposSancion { get; set; } = new List<TiposSancion>();
    public List<TiposPartido> ListaTiposPartidos { get; set; } = new List<TiposPartido>();
    public List<PosicionesJugador> ListaposicionesJugadors { get; set; } = new List<PosicionesJugador>();
    public List<FasesTorneoDTO> ListaFaseTorneo { get; set; } = new List<FasesTorneoDTO>();
    public List<Torneos> ListaTorneo { get; set; } = new List<Torneos>();


    protected override async Task OnInitializedAsync()
    {
        await CargaDatos();

    }

    public async Task CargaDatos()
    {
        ListaTiposSancion = await clienteTipoSancion.ListaTipoSancion();
        ListaTiposPartidos = await clienteTipoPartido.ListaTipoPartidos();
        ListaposicionesJugadors = await clientePosicionJugador.ListaPosicionJugador();
        ListaFaseTorneo = await clienteFaseTorneo.ListaFasesTorneo();
        ListaTorneo = await clienteTorneo.ListaTorneo();
    }


    string selectedTab = "TipoPartido";

    private Task OnSelectedTabChanged(string name)
    {
        selectedTab = name;

        return Task.CompletedTask;
    }
}
