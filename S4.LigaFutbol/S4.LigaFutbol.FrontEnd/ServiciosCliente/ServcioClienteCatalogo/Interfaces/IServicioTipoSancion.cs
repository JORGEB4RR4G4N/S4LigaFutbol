namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;

public interface IServicioTipoSancion
{
    Task<TiposSancion> InsertarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<TiposSancion> ActualizarTipoSancion(TiposSancion tiposSancion, int IdUsuario);
    Task<List<TiposSancion>> ListaTipoSancion();
    Task<TiposSancion> TipoSancion(int IdTipoSancion);

}
