namespace S4.LigaFutbol.DAC.Catalogos;

public class TipoMovimientoDAC : ITipoMovimientoDAC
{
    private readonly Conexion _conexion;
    public TipoMovimientoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }

    public async Task<bool> ActualizarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoMovimiento", tiposMovimiento.IdTipoMovimiento, DbType.Int32);
            parametros.Add("@p_Nombre", tiposMovimiento.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposMovimiento.Descripcion, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_TIPOS_MOVIMIENTO_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarTiposMovimiento(TiposMovimiento tiposMovimiento, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", tiposMovimiento.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposMovimiento.Descripcion, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_TIPOS_MOVIMIENTO_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<TiposMovimiento>> ListaTiposMovimientoS()
    {
        List<TiposMovimiento> Lista = new List<TiposMovimiento>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<TiposMovimiento>("SP_TIPOS_MOVIMIENTO_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<TiposMovimiento> TipoMovimiento(int IdTipoMovimiento)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoMovimiento", IdTipoMovimiento, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<TiposMovimiento>("SP_TIPOS_MOVIMIENTO_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
