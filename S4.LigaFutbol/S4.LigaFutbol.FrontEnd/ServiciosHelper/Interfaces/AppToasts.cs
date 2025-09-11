namespace S4.LigaFutbol.FrontEnd.ServiciosHelper.Interfaces;
public sealed class AppToasts : IAppToasts
{
    private readonly IToastService _toast;

    public AppToasts(IToastService toast) => _toast = toast;
    
    // Defaults globales para TODAS las toasts
    private static void DefaultOptions(ToastInstanceOptions o)
    {
        o.Animated = true;
        o.AnimationDuration = 300;
        o.Autohide = true;
        o.AutohideDelay = 3000;


        o.Opening = e => { Console.WriteLine("Opening"); return Task.CompletedTask; };
        o.Closing = e => { Console.WriteLine("Closing"); return Task.CompletedTask; };
    }

    // Helper para combinar tus defaults con una configuración puntual opcional
    private static Action<ToastInstanceOptions> Merge(Action<ToastInstanceOptions>? configure)
        => (o) =>
        {
            DefaultOptions(o);
            configure?.Invoke(o);
        };

    public Task Info(string msg, string? title = null, Action<ToastInstanceOptions>? c = null)
        => _toast.Info(msg, title, Merge(c));

    public Task Success(string msg, string? title = null, Action<ToastInstanceOptions>? c = null)
        => _toast.Success(msg, title, Merge(c));

    public Task Warning(string msg, string? title = null, Action<ToastInstanceOptions>? c = null)
        => _toast.Warning(msg, title, Merge(c));

    public Task Error(string msg, string? title = null, Action<ToastInstanceOptions>? c = null)
        => _toast.Error(msg, title, Merge(c));
}
