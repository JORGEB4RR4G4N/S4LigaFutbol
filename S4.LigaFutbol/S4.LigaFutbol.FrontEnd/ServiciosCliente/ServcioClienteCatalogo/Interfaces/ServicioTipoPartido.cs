
namespace S4.LigaFutbol.FrontEnd.ServiciosCliente.ServcioClienteCatalogo.Interfaces;

public class ServicioTipoPartido : IServicioTipoPartido
{
    public Task<TiposPartido> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        throw new NotImplementedException();
    }

    public Task<TiposPartido> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        throw new NotImplementedException();
    }

    public Task<List<TiposPartido>> ListaTipoPartido()
    {
        throw new NotImplementedException();
    }

    public Task<TiposPartido> TipoPartido(int IdTipoPartido)
    {
        throw new NotImplementedException();
    }
}
