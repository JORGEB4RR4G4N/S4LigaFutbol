namespace S4.LigaFutbol.FrontEnd.Componentes.Equipos;

public partial class GridEquiposComponent
{
    [Parameter] public List<EquiposDTO> ListaEquiposDTO { get; set; } = new List<EquiposDTO>();
    [Parameter] public EventCallback<int> IdEquipo { get; set; }
    [Parameter] public EventCallback<int> IdEquipoEliminar { get; set; }
    [Parameter] public EventCallback<EquiposDTO> EquipoEditar { get; set; }
    public EquiposDTO EquiposDTO { get; set; } = new EquiposDTO();
    protected string NombreEquipoSeleccionado { get; set; } = string.Empty;
    protected bool Edicion { get; set; }
    private VirtualizeOptions virtualizeOptions = new VirtualizeOptions { DataGridHeight = "400px" };
    public async void SeleccionEquipos(int IdEquipoSeleccionado)
    {
        if (IdEquipoSeleccionado > 0)
        {
            await IdEquipo.InvokeAsync(IdEquipoSeleccionado);
        }

    }
    public async void SeleccionEquipoEliminar(int IdEquipoSeleccionado)
    {
        if (IdEquipoSeleccionado > 0)
        {
            await IdEquipoEliminar.InvokeAsync(IdEquipoSeleccionado);
        }

    }
    public async void SeleccionEquipoEditar(EquiposDTO EquipoSeleccionado)
    {
        if (EquipoSeleccionado != null)
        {
            await EquipoEditar.InvokeAsync(EquipoSeleccionado);
        }

    }

    public void SeleccionEquiposAcciones(EquiposDTO EquipoSeleccionado, bool Editar)
    {
        NombreEquipoSeleccionado = EquipoSeleccionado.Nombre;
        Edicion = Editar;
        ShowModal();

    }

    private Modal modalRef;

    private Task ShowModal()
    {
        return modalRef.Show();
    }
    private Task HideModal()
    {
        return modalRef.Hide();
    }
}
