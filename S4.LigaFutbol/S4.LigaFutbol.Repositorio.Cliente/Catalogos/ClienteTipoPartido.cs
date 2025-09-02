namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClienteTipoPartido : IClienteTipoPartido
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
