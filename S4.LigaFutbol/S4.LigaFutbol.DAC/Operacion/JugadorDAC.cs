namespace S4.LigaFutbol.DAC.Operacion;
public class JugadorDAC : IJugadorDAC
{
    private readonly Conexion _conexion;
    public JugadorDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarJugador(Jugadores jugadores, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdJugador", jugadores.IdJugador, DbType.Int32);
            parametros.Add("@p_IdPosicionJugador", jugadores.IdPosicionJugador, DbType.Int32);
            parametros.Add("@p_Nombre", jugadores.Nombre, DbType.String);
            parametros.Add("@p_Numero", jugadores.Numero, DbType.Int32);


            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_JUGADOR_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarJugador(Jugadores jugadores, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdEquipo", jugadores.IdEquipo, DbType.Int32);
            parametros.Add("@p_IdPosicionJugador", jugadores.IdPosicionJugador, DbType.Int32);
            parametros.Add("@p_Nombre", jugadores.Nombre, DbType.String);
            parametros.Add("@p_Numero", jugadores.Numero, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_JUGADOR_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<Jugadores> Jugador(int IdJugador)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdJugador", IdJugador, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<Jugadores>("SP_JUGADOR_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo)
    {
        List<JugadoresListadoDTO> Lista = new List<JugadoresListadoDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);
                parametros.Add("@p_IdEquipo", IdEquipo, DbType.Int32);
                Lista = (await conexion.QueryAsync<JugadoresListadoDTO>("SP_JUGADOR_CN", parametros, commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

}
