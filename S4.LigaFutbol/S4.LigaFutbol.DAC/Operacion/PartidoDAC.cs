namespace S4.LigaFutbol.DAC.Operacion;

public class PartidoDAC : IPartidoDAC
{
    private readonly Conexion _conexion;
    public PartidoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }

    public async Task<bool> ActualizarCancelarPartido(int IdPartido, string Motivo, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPartido", IdPartido, DbType.Int32);
            parametros.Add("@p_Motivo", Motivo, DbType.String);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_CANCELAR_PARTIDO", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<bool> ActualizarPartidoResultado(Partidos partidos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdPartido", partidos.IdPartido, DbType.Int32);
            parametros.Add("@p_GolesLocal", partidos.GolesLocal, DbType.Int32);
            parametros.Add("@p_GolesVisitante", partidos.GolesVisitante, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_PARTIDO_RESULTADO_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<int> InsertarPartidos(Partidos partidos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", partidos.IdTorneo, DbType.Int32);
            parametros.Add("@p_IdFase", partidos.IdFase, DbType.Int32);
            parametros.Add("@p_IdEquipoLocal", partidos.IdEquipoLocal, DbType.Int32);
            parametros.Add("@p_IdEquipoVisitante", partidos.IdEquipoVisitante, DbType.Int32);
            parametros.Add("@p_Fecha", partidos.Fecha, DbType.DateTime);
            parametros.Add("@p_Estadio", partidos.Estadio, DbType.String);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_PARTIDO_IN", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<int> InsertarProgramaPartidosAdicional(Partidos partidos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", partidos.IdTorneo, DbType.Int32);
            parametros.Add("@p_IdFase", partidos.IdFase, DbType.Int32);
            parametros.Add("@@p_FechaHora", partidos.Fecha, DbType.DateTime);
            parametros.Add("@p_IdEquipoLocal", partidos.IdEquipoLocal, DbType.Int32);
            parametros.Add("@p_IdEquipoVisitante", partidos.IdEquipoVisitante, DbType.Int32);
            parametros.Add("@p_IdTipoPartido", partidos.IdEquipoVisitante, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_PROGRAMAR_PARTIDO_ADICIONAL", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<int> InsertarProgramarPartidos(Partidos partidos, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", partidos.IdTorneo, DbType.Int32);
            parametros.Add("@p_IdFase", partidos.IdFase, DbType.Int32);
            parametros.Add("@@p_FechaHora", partidos.Fecha, DbType.DateTime);
            parametros.Add("@p_IdEquipoLocal", partidos.IdEquipoLocal, DbType.Int32);
            parametros.Add("@p_IdEquipoVisitante", partidos.IdEquipoVisitante, DbType.Int32);
            parametros.Add("@p_IdTipoPartido", partidos.IdEquipoVisitante, DbType.Int32);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_PROGRAMAR_PARTIDO", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }
}
