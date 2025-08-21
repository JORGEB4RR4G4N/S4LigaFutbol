namespace S4.LigaFutbol.DAC.Catalogos;

public class PosicionJugadorDAC : IPosicionJugadorDAC
{
    private readonly Conexion _conexion;
    public PosicionJugadorDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }

    public async Task<bool> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();

            parametros.Add("@p_IdPosicionJugador", posicionesJugador.IdPosicionJugador, DbType.Int32);
            parametros.Add("@p_Nombre", posicionesJugador.Nombre, DbType.String);
            parametros.Add("@p_Abreviatura", posicionesJugador.Abreviatura, DbType.String);


            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_POSICION_JUGADOR_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPosicionJugador", IdPosicionJuagdor, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_POSICION_JUGADOR_DEL", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_Nombre", posicionesJugador.Nombre, DbType.String);
            parametros.Add("@p_Abreviatura", posicionesJugador.Abreviatura, DbType.String);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_POSICION_JUGADOR_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<PosicionesJugador>> ListaPosicionesJugador()
    {
        List<PosicionesJugador> Lista = new List<PosicionesJugador>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                Lista = (await conexion.QueryAsync<PosicionesJugador>("SP_POSICIONES_JUGADOR_CT", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPosicionJuagdor", IdPosicionJuagdor, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<PosicionesJugador>("SP_POSICIONES_JUGADOR_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
