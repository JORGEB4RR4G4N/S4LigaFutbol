namespace S4.LigaFutbol.Front.Layout;

public partial class MainLayout
{
    private IDialogReference? _dialog;
    private readonly UsuarioAcceso usuarioAcceso = new()
    {
        Usuario = "Steve"
    };

    private async Task OpenPanelLeftAsync()
    {
        
        DialogParameters<UsuarioAcceso> parameters = new()
        {
            Content = usuarioAcceso,
            Title = $"Hello {usuarioAcceso.Usuario}",
            Alignment = HorizontalAlignment.Left,
            Modal = false,
            ShowDismiss = true,
            PrimaryAction = null,
            SecondaryAction = null,
            Width = "250px"
            
        };
        _dialog = await DialogService.ShowPanelAsync<NavMenu>(usuarioAcceso, parameters);
        DialogResult result = await _dialog.Result;
        HandlePanel(result);
    }
    private static void HandlePanel(DialogResult result)
    {
        if (result.Cancelled)
        {
            
            return;
        }

        if (result.Data is not null)
        {
            var simplePerson = result.Data as UsuarioAcceso;
            return;
        }
    }
}
