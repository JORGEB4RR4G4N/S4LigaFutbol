namespace S4.LigaFutbol.DAC.Catalogos;

public class TipoImagenDAC : ITipoImagenDAC
{
    private readonly Conexion _conexion;
    public TipoImagenDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarTipoImagen(TiposImagen tiposImagen, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoImagen", tiposImagen.IdTipoImagen, DbType.Int32);
            parametros.Add("@p_Nombre", tiposImagen.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposImagen.Descripcion, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_TIPOS_IMAGEN_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarTipoImagen(TiposImagen tiposImagen, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", tiposImagen.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposImagen.Descripcion, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_TIPOS_IMAGEN_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<TiposImagen>> ListaTipoImagen()
    {
        List<TiposImagen> Lista = new List<TiposImagen>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<TiposImagen>("SP_TIPOS_IMAGEN_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<TiposImagen> TipoImagen(int IdTipoImagen)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoImagen", IdTipoImagen, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<TiposImagen>("SP_TIPOS_IMAGEN_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
