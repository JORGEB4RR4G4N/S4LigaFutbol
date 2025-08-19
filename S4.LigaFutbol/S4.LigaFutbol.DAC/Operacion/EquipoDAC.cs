namespace S4.LigaFutbol.DAC.Operacion;
public class EquipoDAC : IEquipoDAC
{
    private readonly Conexion _conexion;
    public EquipoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarEquipo(Equipos equipos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdEquipo", equipos.IdEquipo, DbType.Int32);
            parametros.Add("@p_IdOrigen", equipos.IdOrigen, DbType.Int32);
            parametros.Add("@p_Nombre", equipos.Nombre, DbType.String);
            parametros.Add("@p_Habilitado", equipos.Habilitado, DbType.Boolean);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_EQUIPO_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<Equipos> Equipo(int IdEquipo)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdEquipo", IdEquipo, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<Equipos>("SP_EQUIPO_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<int> InsertarEquipo(Equipos equipos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", equipos.IdTorneo, DbType.Int32);
            parametros.Add("@p_IdOrigen", equipos.IdOrigen, DbType.Int32);
            parametros.Add("@p_Nombre", equipos.Nombre, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_EQUIPO_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<Equipos>> ListaEquipo()
    {
        List<Equipos> Lista = new List<Equipos>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<Equipos>("SP_EQUIPO_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }
}
