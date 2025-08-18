namespace S4.LigaFutbol.DAC.Catalogos;

public class TipoSancionDAC : ITipoSancionDAC
{
    private readonly Conexion _conexion;
    public TipoSancionDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarFaseTorneo(TiposSancion tiposSancion, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoSancion", tiposSancion.IdTipoSancion, DbType.Int32);
            parametros.Add("@p_Nombre", tiposSancion.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposSancion.Descripcion, DbType.String);
            parametros.Add("@p_Puntos", tiposSancion.Puntos, DbType.Int32);
            parametros.Add("@p_PartidosSuspension", tiposSancion.PuntosSuspension, DbType.Int32);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_TIPOS_SANCION_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<TiposSancion> FaseTorneo(int IdTipoSancion)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTipoSancion", IdTipoSancion, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<TiposSancion>("SP_TIPOS_SANCION_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<int> InsertarFaseTorneo(TiposSancion tiposSancion, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", tiposSancion.Nombre, DbType.String);
            parametros.Add("@p_Descripcion", tiposSancion.Descripcion, DbType.String);
            parametros.Add("@p_Puntos", tiposSancion.Puntos, DbType.Int32);
            parametros.Add("@p_PartidosSuspension", tiposSancion.PuntosSuspension, DbType.Int32);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_TIPOS_SANCION_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<TiposSancion>> ListaFasesTorneo()
    {
        List<TiposSancion> Lista = new List<TiposSancion>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<TiposSancion>("SP_TIPOS_SANCION_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
            GC.Collect();
        }
    }
}
