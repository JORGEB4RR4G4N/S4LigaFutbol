
using S4.LigaFutbol.Comunes.Catalogos;

namespace S4.LigaFutbol.DAC.Catalogos;

public class TipoPartidoDAC : ITipoPartidoDAC
{
    private readonly Conexion _conexion;
    public TipoPartidoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoPartido", tiposPartido.IdTipoPartido, DbType.Int32);
            parametros.Add("@p_Nombre", tiposPartido.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposPartido.Descripcion, DbType.String);
            parametros.Add("@p_AfectaPosiciones", tiposPartido.AfectaPosicion, DbType.Boolean);
            parametros.Add("@p_EsOficial", tiposPartido.EsOficial, DbType.Boolean);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_TIPOS_PARTIDO_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarTipoPartido(TiposPartido tiposPartido, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", tiposPartido.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposPartido.Descripcion, DbType.String);
            parametros.Add("@p_AfectaPosiciones", tiposPartido.AfectaPosicion, DbType.Boolean);
            parametros.Add("@p_EsOficial", tiposPartido.EsOficial, DbType.Boolean);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_TIPOS_PARTIDO_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<TiposPartido>> ListaTipoPartido()
    {
        List<TiposPartido> Lista = new List<TiposPartido>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<TiposPartido>("SP_TIPOS_PARTIDO_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
            GC.Collect();
        }
    }

    public async Task<TiposPartido> TipoPartido(int IdTipoPartido)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoPartido", IdTipoPartido, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<TiposPartido>("SP_TIPOS_PARTIDO_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
