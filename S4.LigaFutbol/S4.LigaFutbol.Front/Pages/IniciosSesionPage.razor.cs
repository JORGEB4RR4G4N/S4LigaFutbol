namespace S4.LigaFutbol.Front.Pages;

public partial class IniciosSesionPage
{
    [Inject] NavigationManager Nav { get; set; } = default!;
    public UsuarioAcceso usuarioAccesoObject { get; set; } = new UsuarioAcceso();

    async Task ValidarUsuario()
    {

        var data = usuarioAccesoObject;
        // Redirige a la página Home
        Nav.NavigateTo("/PanelPrincipal");

    }
}
