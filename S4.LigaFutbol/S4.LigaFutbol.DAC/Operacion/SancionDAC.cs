namespace S4.LigaFutbol.DAC.Operacion;

public class SancionDAC : ISancionDAC
{
    private readonly Conexion _conexion;
    public SancionDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }

    public async Task<int> InsertarSancion(Sanciones sanciones, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPartido", sanciones.IdPartido, DbType.Int32);
            parametros.Add("@p_IdJugador", sanciones.IdJugador, DbType.Int32);
            parametros.Add("@p_IdTipoSancion", sanciones.IdTipoSancion, DbType.Int32);
            parametros.Add("@p_Minuto", sanciones.Minuto, DbType.Int32);
            parametros.Add("@p_Observaciones", sanciones.Observacion, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_SANCION_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo)
    {
        List<SancionesEquiposDTO> Lista = new List<SancionesEquiposDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);

                Lista = (await conexion.QueryAsync<SancionesEquiposDTO>("SP_SANCIONES_EQUIPO_CN", parametros, commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador)
    {
        List<SancionesJugadorDTO> Lista = new List<SancionesJugadorDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdJugador", IdJugador, DbType.Int32);

                Lista = (await conexion.QueryAsync<SancionesJugadorDTO>("SP_SANCIONES_JUGADOR_CN", parametros, commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }
}
