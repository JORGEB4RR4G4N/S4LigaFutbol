namespace S4.LigaFutbol.DAC.Operacion;

public class TorneoDAC : ITorneoDAC
{
    private readonly Conexion _conexion;
    public TorneoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarTorneo(Torneos torneo, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", torneo.IdTorneo, DbType.Int32);
            parametros.Add("@p_Nombre", torneo.Nombre, DbType.String);
            parametros.Add("@p_FechaInicio", torneo.FechaIncio, DbType.DateTime);
            parametros.Add("@p_FechaFin", torneo.FechaFin, DbType.DateTime);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_TORNEO_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarTorneo(Torneos torneo, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", torneo.Nombre, DbType.String);
            parametros.Add("@p_FechaInicio", torneo.FechaIncio, DbType.DateTime);
            parametros.Add("@p_FechaFin", torneo.FechaFin, DbType.DateTime);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_TORNEO_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<Torneos>> ListaTorneo()
    {

        List<Torneos> Lista = new List<Torneos>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<Torneos>("SP_TORNEO_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<Torneos> Torneo(int IdTorneo)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<Torneos>("SP_TORNEO_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
