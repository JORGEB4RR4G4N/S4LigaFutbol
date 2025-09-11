namespace S4.LigaFutbol.FrontEnd.ServiciosHelper.Interfaces;
public interface IAppToasts
{
    Task Info(string message, string? title = null, Action<ToastInstanceOptions>? configure = null);
    Task Success(string message, string? title = null, Action<ToastInstanceOptions>? configure = null);
    Task Warning(string message, string? title = null, Action<ToastInstanceOptions>? configure = null);
    Task Error(string message, string? title = null, Action<ToastInstanceOptions>? configure = null);
}
