namespace S4.LigaFutbol.FrontEnd.Pages;

public partial class InicioSesionPage
{
    [Inject] NavigationManager Nav { get; set; } = default!;
    public Validations validations;
    public UsuarioAcceso usuarioAccesoObject { get; set; } = new UsuarioAcceso();

    async Task ValidarUsuario()
    {
        if (await validations.ValidateAll())
        {
            var data = usuarioAccesoObject;
            // Redirige a la página Home
            Nav.NavigateTo("/PanelPrincipal");
        }
    }
}
