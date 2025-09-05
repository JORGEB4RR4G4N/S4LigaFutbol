namespace S4.LigaFutbol.DAC.Catalogos;
public class FasesTorneoDAC : IFasesTorneoDAC
{
    private readonly Conexion _conexion;
    public FasesTorneoDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<bool> ActualizarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdFase", fasesTorneo.IdFase, DbType.Int32);
            parametros.Add("@p_Nombre", fasesTorneo.Nombre, DbType.Int32);
            parametros.Add("@p_EsEliminatoria", fasesTorneo.EsEliminatoria, DbType.Boolean);
            parametros.Add("@p_EquiposQueClasifican", fasesTorneo.EquiposQueClasifican, DbType.Int32);
            parametros.Add("@p_Orden", fasesTorneo.Orden, DbType.Int32);
            parametros.Add("@p_FechaInicio", fasesTorneo.FechaInicio, DbType.DateTime);
            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteAsync("SP_FASE_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado > 0;
        }
    }

    public async Task<FasesTorneoDTO> FaseTorneo(int IdFase)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {

            var parametros = new DynamicParameters();
            parametros.Add("@p_IdFase", IdFase, DbType.Int32);

            return await conexion.QueryFirstOrDefaultAsync<FasesTorneoDTO>("SP_FASE_CN", parametros, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<int> InsertarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario)
    {
        using (var conexion = _conexion.ObtieneConexion())
        {
            var parametros = new DynamicParameters();
            parametros.Add("@p_IdTorneo", fasesTorneo.IdFase, DbType.Int32);
            parametros.Add("@p_Nombre", fasesTorneo.Nombre, DbType.Int32);
            parametros.Add("@p_EsEliminatoria", fasesTorneo.EsEliminatoria, DbType.Boolean);
            parametros.Add("@p_EquiposQueClasifican", fasesTorneo.EquiposQueClasifican, DbType.Int32);
            parametros.Add("@p_Orden", fasesTorneo.Orden, DbType.Int32);
            parametros.Add("@p_FechaInicio", fasesTorneo.FechaInicio, DbType.DateTime);
            parametros.Add("@p_Habilitado", fasesTorneo.Habilitado, DbType.Boolean);

            parametros.Add("@p_IdUsuario", IdUsuario, DbType.UInt32);
            var Resultado = await conexion.ExecuteScalarAsync<int>("SP_FASE_ED", parametros, commandType: CommandType.StoredProcedure);
            return Resultado;
        }
    }

    public async Task<List<FasesTorneoDTO>> ListaFasesTorneo(int? IdTorneo)
    {
        List<FasesTorneoDTO> Lista = new List<FasesTorneoDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);
                Lista = (await conexion.QueryAsync<FasesTorneoDTO>("SP_FASE_CT",parametros, commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }
}
