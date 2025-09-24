namespace S4.LigaFutbol.Front.Componentes.Equipos;

public partial class EquiposComponent
{
    [Inject] public IClienteEquipo clienteEquipo { get; set; }
    [Inject] public IClienteTorneo clienteTorneo { get; set; }
    [Inject] public IClienteJugador clienteJugador { get; set; }

    public List<EquiposDTO> ListaEquiposDTOs { get; set; } = new List<EquiposDTO>();
    public List<Torneos> ListaTorneo { get; set; } = new List<Torneos>();
    public List<JugadoresListadoDTO> ListaJugadoresDTO { get; set; } = new List<JugadoresListadoDTO>();
    private string IdTorneoSeleccionado { get; set; }
    private Torneos torneosSeleccionado { get; set; }
    private bool CargandoDatos { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await CargaDatos();
    }

    public async Task CargaDatos()
    {
        CargandoDatos = true;
        ListaTorneo = await clienteTorneo.ListaTorneo();
        IdTorneoSeleccionado = ListaTorneo.First().IdTorneo.ToString();
        //ListaEquiposDTOs = await clienteEquipo.ListaEquipo(Convert.ToInt32(IdTorneoSeleccionado));
        CargandoDatos = false;
    }
    public async Task CargarEquipos(Torneos IdTorneo)
    {
        CargandoDatos = true;
        ListaEquiposDTOs = await clienteEquipo.ListaEquipo(IdTorneo);
        CargandoDatos = false;
    }
    public async Task CargaJugadores(int IdEquipo)
    {
        ListaJugadoresDTO = await clienteJugador.ListaJugadorPorTorneoEquipo(Convert.ToInt32(IdTorneoSeleccionado), IdEquipo);
    }
    public async Task EditarEquipo(EquiposDTO equiposDTOEditar)
    {
        //var EquipoEditado = await clienteEquipo.ActualizarEquipo(equiposDTOEditar);
    }
    public async Task EliminarEquipo(int IdEquipo)
    {

        EquiposDTO EquipoEiminar = new EquiposDTO() { IdEquipo = IdEquipo };
        ListaEquiposDTOs.RemoveAt(ListaEquiposDTOs.FindIndex(x => x.IdEquipo == IdEquipo));
        //var EquipoEliminado = await clienteEquipo.ActualizarEquipo(EquipoEiminar);


    }
}
