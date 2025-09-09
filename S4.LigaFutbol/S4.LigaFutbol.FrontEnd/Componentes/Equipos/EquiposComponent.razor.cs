namespace S4.LigaFutbol.FrontEnd.Componentes.Equipos;

public partial class EquiposComponent
{
    [Inject] public IClienteEquipo clienteEquipo { get; set; }
    [Inject] public IClienteTorneo clienteTorneo { get; set; }
    [Inject] public IClienteJugador clienteJugador { get; set; }

    public List<EquiposDTO> ListaEquiposDTOs { get; set; } = new List<EquiposDTO>();
    public List<Torneos> ListaTorneo { get; set; } = new List<Torneos>();
    public List<JugadoresListadoDTO> ListaJugadoresDTO { get; set; } = new List<JugadoresListadoDTO>();
    private string IdTorneoSeleccionado { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await CargaDatos();
    }

    public async Task CargaDatos()
    {
        ListaTorneo = await clienteTorneo.ListaTorneo();
        IdTorneoSeleccionado = ListaTorneo.First().IdTorneo.ToString();
        ListaEquiposDTOs = await clienteEquipo.ListaEquipo(Convert.ToInt32(IdTorneoSeleccionado));
    }

    public async Task CargaJugadores(int IdEquipo)
    {
        ListaJugadoresDTO = await clienteJugador.ListaJugadorPorTorneoEquipo(Convert.ToInt32(IdTorneoSeleccionado), IdEquipo);
    }
}
