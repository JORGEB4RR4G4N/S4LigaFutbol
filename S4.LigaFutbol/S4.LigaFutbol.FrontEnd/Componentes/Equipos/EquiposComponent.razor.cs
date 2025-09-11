namespace S4.LigaFutbol.FrontEnd.Componentes.Equipos;

public partial class EquiposComponent
{
    [Inject] public IClienteEquipo clienteEquipo { get; set; }
    [Inject] public IClienteTorneo clienteTorneo { get; set; }
    [Inject] public IClienteJugador clienteJugador { get; set; }
    [Inject] public IAppToasts appToasts { get; set; }

    public List<EquiposDTO> ListaEquiposDTOs { get; set; } = new List<EquiposDTO>();
    public List<Torneos> ListaTorneo { get; set; } = new List<Torneos>();
    public List<JugadoresListadoDTO> ListaJugadoresDTO { get; set; } = new List<JugadoresListadoDTO>();
    private string IdTorneoSeleccionado { get; set; }
    private bool AccionExitosa { get; set; }

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
    public async Task EditarEquipo(EquiposDTO equiposDTOEditar)
    {
        //var EquipoEditado = await clienteEquipo.ActualizarEquipo(equiposDTOEditar);
    }
    public async Task EliminarEquipo(int IdEquipo)
    {
        EquiposDTO EquipoEiminar = new EquiposDTO() { IdEquipo = IdEquipo };
        //ListaEquiposDTOs.RemoveAt(ListaEquiposDTOs.FindIndex(x => x.IdEquipo == IdEquipo));
        //var EquipoEliminado = await clienteEquipo.ActualizarEquipo(EquipoEiminar);

        AccionExitosa = true;

        await appToasts.Success("Accion Realizada", "Eliminado");
    }

   
}
