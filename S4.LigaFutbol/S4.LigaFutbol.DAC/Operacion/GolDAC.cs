namespace S4.LigaFutbol.DAC.Operacion;

public class GolDAC : IGolDAC
{
    private readonly Conexion _conexion;
    public GolDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }

    public async Task<int> EliminarGol(Goles gol, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdGol", gol.IdPartido, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_GOL_DEL", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<int> InsertarGol(Goles gol, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPartido", gol.IdPartido, DbType.Int32);
            parametros.Add("@p_IdJugador", gol.IdJugador, DbType.Int32);
            parametros.Add("@p_Minuto", gol.Mintuo, DbType.Int32);
            parametros.Add("@p_EsPenalti", gol.EsPenalti, DbType.Boolean);
            parametros.Add("@p_EsFalta", gol.EsFalta, DbType.Boolean);
            parametros.Add("@p_IdJugadorAsistencia", gol.IdJugadorAsistencia, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_GOL_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido)
    {
        List<GolesJugadorDTO> Lista = new List<GolesJugadorDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {

                Lista = (await conexion.QueryAsync<GolesJugadorDTO>("SP_GOLES_PARTIDO_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }
}
