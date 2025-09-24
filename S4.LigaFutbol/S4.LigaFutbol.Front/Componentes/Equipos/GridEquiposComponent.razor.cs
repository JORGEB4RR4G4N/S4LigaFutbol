namespace S4.LigaFutbol.Front.Componentes.Equipos;

public partial class GridEquiposComponent
{
    [Parameter] public IQueryable<EquiposDTO> ListaEquiposDTO { get; set; } = Enumerable.Empty<EquiposDTO>().AsQueryable();
    [Parameter] public EventCallback<int> IdEquipo { get; set; }
    [Parameter] public EventCallback<int> EquipoEliminar { get; set; }
    [Parameter] public EventCallback<EquiposDTO> EquipoEditar { get; set; }
    [Parameter] public bool Cargando { get; set; } = false;
    public EquiposDTO EquiposDTOOSeleccionado { get; set; } = new EquiposDTO();
    protected string NombreEquipoSeleccionado { get; set; } = string.Empty;
    protected bool Edicion { get; set; }
    

    public async void SeleccionEquipos(int IdEquipoSeleccionado)
    {
        if (IdEquipoSeleccionado > 0)
        {
            await IdEquipo.InvokeAsync(IdEquipoSeleccionado);
        }

    }
    public async void SeleccionEquipoEditarEliminar()
    {
        if (Edicion)
        {
            EquiposDTOOSeleccionado.Nombre = NombreEquipoSeleccionado;
            await EquipoEditar.InvokeAsync(EquiposDTOOSeleccionado);
        }
        else
            await EquipoEliminar.InvokeAsync(EquiposDTOOSeleccionado.IdEquipo);
    }

    public void SeleccionEquiposAcciones(EquiposDTO EquipoSeleccionado, bool Editar)
    {
        EquiposDTOOSeleccionado = EquipoSeleccionado;
        NombreEquipoSeleccionado = EquipoSeleccionado.Nombre;
        Edicion = Editar;
    }
}
