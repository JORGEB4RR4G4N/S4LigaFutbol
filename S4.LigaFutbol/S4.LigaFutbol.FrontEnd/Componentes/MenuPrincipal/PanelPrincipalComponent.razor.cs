
namespace S4.LigaFutbol.FrontEnd.Componentes.MenuPrincipal;

public partial class PanelPrincipalComponent
{
    [Inject] IServicioTipoSancion servicioTipoSancion { get; set; }



    protected override async Task OnInitializedAsync()
    {

        var lista = await servicioTipoSancion.ListaTipoSancion();
        Console.WriteLine(lista.FirstOrDefault().Descripcion);
    }
}
